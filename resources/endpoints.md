# Endpoints

## Inventory list

### Base URL:

- `{server ip}/inventory`

### Get:

- `/get/list/all`
  Returns everything in the inventory in a json format.

- `/get/list/count/{amount}`
  Returns the specified amount of items in the inventory.

- `/get/list/query/{query}`
  Searches for the query in the inventory, and returns the result.

### Post:

- `/post/list/add`

```json
{
  "ftzNumber": "{ftzNumber}",
  "altName": "{altName}",
  "description": "{description}",
  "section": "{section}",
  "sectionName": "{sectionName}",
  "placementNotes": "{placementNotes}",
  "amount": "{amount}",
  "picture": "{picture}"
}
```
