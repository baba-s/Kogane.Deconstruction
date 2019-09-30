# Uni Deconstruction

C# 7.0 新機能の分解（Deconstruction）を Unity の Vector2、Vector3、Vector4、Color、Rect などのいくつかの型で使用できるようにするパッケージ

![](https://img.shields.io/badge/Unity-2018.3%2B-red.svg)
![](https://img.shields.io/badge/.NET-4.x-orange.svg)
[![](https://img.shields.io/github/license/baba-s/uni-deconstruction.svg)](https://github.com/baba-s/uni-deconstruction/blob/master/LICENSE)

## インストール

```json
"com.baba_s.uni_deconstruction": "https://github.com/baba-s/uni-deconstruction.git",
```

manifest.json に上記の記述を追加します  

## 使用例

### KeyValuePair

```cs
var table = new Dictionary<int, string>();

foreach ( var ( key, value ) in table )
{
}
```

### Vector2

```cs
var ( x, y ) = new Vector2( 1, 2 );
```

### Vector2Int

```cs
var ( x, y ) = new Vector2Int( 1, 2 );
```

### Vector3

```cs
var ( x, y ) = new Vector3( 1, 2, 3 );
```

```cs
var ( x, y, z ) = new Vector3( 1, 2, 3 );
```

### Vector3Int

```cs
var ( x, y, z ) = new Vector3Int( 1, 2, 3 );
```

### Vector4

```cs
var ( x, y ) = new Vector4( 1, 2, 3, 4 );
```

```cs
var ( x, y, z ) = new Vector4( 1, 2, 3, 4 );
```

```cs
var ( x, y, z, w ) = new Vector4( 1, 2, 3, 4 );
```

### Color

```cs
var ( r, g, b ) = new Color( 1, 0.75f, 0.5f, 0.25f );
```

```cs
var ( r, g, b, a ) = new Color( 1, 0.75f, 0.5f, 0.25f );
```

### Color32

```cs
var ( r, g, b ) = new Color32( 255, 192, 128, 64 );
```

```cs
var ( r, g, b, a ) = new Color32( 255, 192, 128, 64 );
```

### Rect

```cs
var ( x, y, width, height ) = new Rect( 1, 2, 3, 4 );
```

```cs
var ( position, size ) = new Rect( 1, 2, 3, 4 );
```

### DateTime

```cs
var ( year, month, day ) = new DateTime( 2019, 1, 2, 3, 4, 5 );
```

```cs
var ( year, month, day, hour, minute, second ) = new DateTime( 2019, 1, 2, 3, 4, 5 );
```

### null 許容型

```cs
var ( hasValue, value ) = new int?();
```

```cs
var ( hasValue, value ) = new int?( 25 );
```
