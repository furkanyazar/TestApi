# Update

Used to update a product.

**URL**: `/api/Products`

**Method**: `PUT`

**Data constraints**

```json
{
  "id": 0,
  "name": "string",
  "unitPrice": 0.0,
  "unitsInStock": 0
}
```

**Data example**

```json
{
  "id": 1,
  "name": "Apple",
  "unitPrice": 4.99,
  "unitsInStock": 10
}
```

## Success Response

**Code**: `200 OK`

**Content example**

```json
{
  "id": 1,
  "name": "Apple",
  "unitPrice": 4.99,
  "unitsInStock": 10
}
```

## Error Response

**Condition**: If product don't exists.

**Code**: `400 BAD REQUEST`

**Content**:

```json
{
  "type": "https://example.com/probs/business",
  "title": "Rule violation",
  "status": 400,
  "detail": "ProductNotExists"
}
```

### Or

**Condition**: If product name already exists.

**Code**: `400 BAD REQUEST`

**Content**:

```json
{
  "type": "https://example.com/probs/business",
  "title": "Rule violation",
  "status": 400,
  "detail": "ProductNameAlreadyExists"
}
```

### Or

**Condition**: If request body has a validation error or have validation errors.

**Code**: `400 BAD REQUEST`

**Content**:

```json
{
  "type": "https://example.com/probs/validation",
  "title": "Validation error(s)",
  "status": 400,
  "detail": "One or more validation errors occurred.",
  "Errors": [
    {
      "Property": "UnitPrice",
      "Errors": ["'Unit Price' must not be empty."]
    },
    {
      "Property": "UnitsInStock",
      "Errors": ["'Units In Stock' must not be empty."]
    }
  ]
}
```

### Or

**Condition**: Otherwise.

**Code**: `500 INTERNAL SERVER ERROR`

**Content**:

```json
{
  "type": "https://example.com/probs/internal",
  "title": "Internal server error",
  "status": 500,
  "detail": "Internal server error"
}
```
