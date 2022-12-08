# Endpoints

## Inventory list

### Base URL:

#### `{server ip}/api/inventory`

### Get:

#### `/get/all`

Returns everything in the inventory in a json format.

An example return body may lok like this.

```json
{
  {
    "ftzNumber": "FTZ-5678",
    "altName": "Engine Oil",
    "description": "High-quality engine oil for improved performance.",
    "section": "B2",
    "sectionName": "Vehicle Fluids",
    "placementNotes": "Located on shelf 2, in the back corner of the room.",
    "amount": 10,
    "picture": "base-64 encoded image string"
  }
  {
    "ftzNumber": "FTZ-9101",
    "altName": "Tire Pressure Gauge",
    "description": "Digital tire pressure gauge with LCD display.",
    "section": "C3",
    "sectionName": "Tire Tools",
    "placementNotes": "Located on shelf 3, next to the air compressor.",
    "amount": 3,
  }
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
}
```

#### `/get/count/{amount}`

Returns the specified amount of items in the inventory.

An example of a return body for `/get/count/2` may look like this.

```json
{
  {
    "ftzNumber": "FTZ-1212",
    "altName": "Transmission Fluid",
    "description": "High-quality transmission fluid for improved transmission performance.",
    "section": "J10",
    "sectionName": "Transmission Fluids",
    "placementNotes": "Located on shelf 10, next to the transmission filters.",
    "amount": 6,
  }
  {
    "ftzNumber": "FTZ-2323",
    "altName": "Engine Mount",
    "description": "Heavy-duty engine mount for improved engine stability and performance.",
    "section": "K11",
    "sectionName": "Engine Mounts",
    "placementNotes": "Located on shelf 11, next to the engine brackets.",
    "amount": 2,
    "picture": "base-64 encoded image string"
  }
}
```

#### `/get/query/{query}`

Searches for the query in the inventory, and returns the result.

An example of a return body for `/get/query/wrench/` may look like this.

```json
{
  {
    "ftzNumber": "FTZ-3434",
    "altName": "Combination Wrench Set",
    "description": "Set of combination wrenches in various sizes for a variety of tasks.",
    "section": "L12",
    "sectionName": "Hand Tools",
    "placementNotes": "Located on shelf 12, next to the socket sets.",
    "amount": 10,
    "picture": "base-64 encoded image string"
  }
  {
    "ftzNumber": "FTZ-4545",
    "altName": "Torque Wrench",
    "description": "Precision torque wrench with a range of 20-100 ft-lbs.",
    "section": "M13",
    "sectionName": "Specialty Tools",
    "placementNotes": "Located on shelf 13, next to the impact sockets.",
    "amount": 4,
    "picture": "base-64 encoded image string"
  }
}
```

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
- `amount` **(optional)**: The amount of the item in the inventory. If not specified, this will default to 1.
- `picture` **(optional)**: A base-64 encoded image of the inventory item.

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

On success it will return a `201 Created` response if the item was successfully added to the inventory,
which will include the FTZ number of the item, and the alt name.
Otherwise an appropriate error will be returned.
