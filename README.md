## Diagrams
```mermaid
erDiagram
	sparePart {
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

	alternativeNo {
		int id
		varchar(255) ftzNo
		varchar(255) altNo
	}

	section {
		int id
		varchar(100) name
	}
```
