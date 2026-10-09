## Dependency tiers

A class may reference lower tiers only — never its own or higher. Keeps the graph
acyclic.

BuildingModel may use Utils. Utils must never use BuildingModel.

| Tier | Folder or Class | May depend on |
|---|---|---|
| 0 | `SubLevel`, `IFlattenable` | Utils |
| 1 | `Level`, `Floor`, `Wall` | tier 0, Utils |
| 2 | `Building` | tiers 0-1, Utils |

Each folder has its own namespaces and tiers.
