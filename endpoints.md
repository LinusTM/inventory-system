# Endpoints

## Inventory list

### Base URL:
**/inventory**

### Get:
**/get/list/all**

**/get/list/count/{amount}**

**/get/list/query/{query}**

### Post:
**/post/list/add**
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
