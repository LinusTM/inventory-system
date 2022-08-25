# Inventory system
A project to help educators and students sort, track and get parts for various different vocational educations.
Built on Svelte with SvelteKit, using PostgreSQL and C#, with ASP.NET Core, for the backend.


## Entity Relations
```mermaid
erDiagram
SPAREPART ||--|{ ALTERNATIVE_NO : contains
SPAREPART ||--|{ SECTION : contains
SPAREPART {
	int id
		varchar ftzNo(FK)
		varchar name
		int amount
		int criticalAmount
		int section(FK)
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


## Wireframe
![wireframe](./resources/wireframe.png)

