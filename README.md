# Inventory system
A project to help educators and students sort, track and get parts for various different vocational educations.
Built on Svelte with SvelteKit, using PostgreSQL and C#, with ASP.NET Core, for the backend.


## Entity Relations
```mermaid
erDiagram
SPAREPART ||--|{ ALTERNATIVE_NO : contains
SPAREPART ||--|{ ALTERNATIVE_SECTION_NAME : contains
SPAREPART {
	int id
		varchar ftzNo PK
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
		int id PK
			varchar ftzNo FK
			varchar altNo
	}
	ALTERNATIVE_SECTION_NAME {
		int id PK
			int section FK
			varchar name
	}
```


## Wireframe
![wireframe](./resources/wireframe.png)

