# Endpoints

## Inventory list

### Base URL:

- `{server ip}/inventory`

### Get:

#### `/get/all`

Returns everything in the inventory in a json format.

#### `/get/count/{amount}`

Returns the specified amount of items in the inventory.

#### `/get/query/{query}`

Searches for the query in the inventory, and returns the result.

### Put:

#### `/put/add`

This endpoint is used to add new items to the inventory database.
It accepts the following parameters.

- `ftzNumber`: The FTZ number for the inventory item.
- `altName`: An alternate name for the inventory item.
- `description`: A description of the inventory item.
- `section`: The section in which the item is located.
- `sectionName`: The name of the section in which the item is located.
- `placementNotes`: Any additional notes about the item's placement in the inventory.
- `amount` (optional): The amount of the item in the inventory. If not specified, this will default to 1.
- `picture` (optional): A base-64 encoded image of the inventory item.

An example request body may look like this.

```json
{
  "ftzNumber": "FTZ-1234",
  "altName": "Spare Part",
  "description": "A spare part for use in repair.",
  "section": "A1",
  "sectionName": "Spare Parts",
  "placementNotes": "Located on shelf 1, next to the blue tools.",
  "amount": 5,
  "picture": "base-64 encoded image string"
}
```

On success it will return an empty `204 No Content` response if the item was successfully added to the inventory,
Otherwise an appropriate error will be returned.

- `amount` will default to 1 if not specified.
- The `picture` is optional.
- The `picture` should be a jpg in base-64.
