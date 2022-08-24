## Diagrams
```mermaid
erDiagram
	SPAREPART {
		int id
		varchar(255) ftzNo
		varchar(255) name
		int amount
		int criticalAmount
		int section
		int shelf
		int drawer
		text description
		varchar img
	}

	ALTERNATIVE_NO {
		int id
		varchar(255) ftzNo
		varchar(255) altNo
	}

	SECTION {
		int id
		varchar(100) name
	}
```
