# GetList

Used to get list products.

**URL**: `/api/Products?PageIndex=0&PageSize=10`

**URL Parameters**:

- `PageIndex=[integer]` where `PageIndex` is the index of the page. Its initial value is 0.
- `PageSize=[integer]` where `PageSize` is the number of items per page.

**Method**: `GET`

## Success Response

**Code**: `200 OK`

**Content example**

```json
{
  "items": [
    {
      "id": 1,
      "name": "Apple",
      "unitPrice": 5.49,
      "unitsInStock": 15
    }
  ],
  "index": 0,
  "size": 10,
  "count": 1,
  "pages": 1,
  "hasPrevious": false,
  "hasNext": false
}
```

**Content Parameters**:

- `items=[object]` where `items` is the data.
- `index=[integer]` where `index` is the current page index.
- `size=[integer]` where `size` is the current page size.
- `count=[integer]` where `count` is the total number of items.
- `pages=[integer]` where `pages` is the total number of pages.
- `hasPrevious=[boolean]` where `hasPrevious` tells whether the previous page exists.
- `hasNext=[boolean]` where `hasNext` tells whether the next page exists.

## Error Response

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
