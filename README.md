# Inventory System

A project to help educators and students sort, track and get parts for various different vocational educations.
Built on Svelte with SvelteKit, using MariaDB and C#, with ASP.NET Core and Entity Framework, for the backend.

## API Endpoints

[endpoints.md](./resources/endpoints.md)

## Entity Relations

```mermaid
erDiagram
SPAREPART ||--|{ ALTERNATIVE_NO : contains
SPAREPART ||--|{ ALTERNATIVE_SECTION_NAME : contains
SPAREPART {
	int id PK
		varchar ftzNo
		varchar name
		int amount
		int criticalAmount
		int section
		text description
		text note
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
			varchar note
	}
```

## Wireframe

![wireframe](./resources/wireframe.png)
