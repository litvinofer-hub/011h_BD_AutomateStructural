# Structural Automation

## Dependency tiers

A project may reference lower tiers only — never its own or higher. Keeps the graph
acyclic.

| Tier | Project | May depend on | References |
|---|---|---|---|
| 0 | `Utils` | nothing | — |
| 1 | `BuildingModel` | tier 0 | `Utils` |
| 2 | `AutoCadCommands` | tiers 0-1 | `Utils`, `BuildingModel` |

`Utils` and `BuildingModel` keep their own tiers in a `TIERS.md`, and so does each
folder inside them, with its own namespace.

## Equality

A `Utils.Geometry` shape is its geometry, so it compares by geometry: two shapes are
equal when they fill the same space, whichever corner each was built from and whichever
way round its edges run. Coordinates are compared within a tolerance, not exactly.
This covers every class in `Utils.Geometry`. The tolerances themselves live in
`Utils.SystemParams`.

A `BuildingModel` element is an element of the building, so it compares by `Id`: two
elements built over the same space are two elements, and one can be taken out without
the other going with it. This covers `SubLevel`, `Level`, `Floor`, `Opening` and `Wall`.
`Building` has an `Id` but compares by reference, and `WallBorders` is a set of
parameters, not an element.
