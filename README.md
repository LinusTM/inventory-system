## Entity Relations
```mermaid
erDiagram
SPAREPART ||--|{ ALTERNATIVE_NO : contains
SPAREPART ||--|{ SECTION : contains
SPAREPART {
	int id
		varchar ftzNo
		varchar name
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
			varchar ftzNo
			varchar altNo
	}
	SECTION {
		int id
			varchar name
	}
```

