"""
Package version utilities for Jungle MCP Server.
"""

from importlib import metadata
from pathlib import Path

import tomli

PACKAGE_NAME = "junglemcpserver"


def _version_from_local_pyproject() -> str:
    """Locate the nearest pyproject.toml that matches our package name."""
    current = Path(__file__).resolve()
    for parent in current.parents:
        candidate = parent / "pyproject.toml"
        if not candidate.exists():
            continue
        try:
            with candidate.open("rb") as f:
                data = tomli.load(f)
        except (OSError, tomli.TOMLDecodeError):
            continue

        project_table = data.get("project") or {}
        poetry_table = data.get("tool", {}).get("poetry", {})

        project_name = project_table.get("name") or poetry_table.get("name")
        if project_name and project_name.lower() != PACKAGE_NAME.lower():
            continue

        version = project_table.get("version") or poetry_table.get("version")
        if version:
            return version
    raise FileNotFoundError("pyproject.toml not found for junglemcpserver")


def get_package_version() -> str:
    """
    Get package version in different ways:
    1. First we try the installed metadata - this is because uvx is used on the asset store
    2. If that fails, we try to read from pyproject.toml - this is available for users who download via Git
    Default is "unknown", but that should never happen
    """
    try:
        return metadata.version(PACKAGE_NAME)
    except Exception:
        # Fallback for development: read from pyproject.toml
        try:
            return _version_from_local_pyproject()
        except Exception:
            return "unknown"
