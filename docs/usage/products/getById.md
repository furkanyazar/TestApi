# GetById

Used to get a product by id.

**URL**: `/api/Products/{id}`

**URL Routes**:

- `id=[integer]` where `id` is the ID of the product.

**Method**: `GET`

## Success Response

**Code**: `200 OK`

**Content example**

```json
{
  "id": 1,
  "name": "Apple",
  "unitPrice": 5.49,
  "unitsInStock": 15
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
