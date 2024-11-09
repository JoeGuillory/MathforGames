#  [MathLibrary](https://github.com/JoeGuillory/MathforGames)

This library handles Vector and Matrix math


## Contents
1. [Vector2](#vector2)
1. [Vector3](#vector3) 
1. [Vector4](#vector4)
1. [Matrix3](#matrix3)
1. [Matrix4](#matrix4)

---
## Vector2

This represents 2D vectors and points 

### Properties
|||
|------------|------------------------------------|
| Magnitude  | Gets the length of the vector      |
| Normalized | Sets the length of the vector to 1 |

### Constructor
|         |                    |
|---------|--------------------|
| Vector2 |  Input a x and a y |

#### Example

```cs
Vector2 example = new Vector2(1,1);
```

### Functions
Functions for Vector2

|              |                                                               |
|--------------|---------------------------------------------------------------|
| ToString     | Out puts a string of the vector                               |
| Normalize    | Normalizes a vector                                           |
| DotProduct   | Gets the Dot product of this Objects vector to another vector |
| CrossProduct | Swaps the x and y of a vector                                 |
| Angle        | Gets the angle of this object to another object               |
| Distance     | Gets the distance from this objecto to another object         |

### Operators

|    |                                  |
|----|----------------------------------|
| == | Checks if Vectors are Equal      |
| != | Checks if Vectors are Not Equal  |
| +  | Adds two Vectors                 |
| -  | Subtracts two Vectors            |
| *  |  Multiply the Vector by a Scaler |
| /  | Divides the Vector by a Scaler   |
	

---
## Vector3

Represents 3D Vectors and points

### Properties
|||
|------------|------------------------------------|
| Magnitude  | Gets the length of the vector      |
| Normalized | Sets the length of the vector to 1 |

### Constructor
|         |                    |
|---------|--------------------|
| Vector3 |  Input a x , y and z |

#### Example

```cs
Vector3 example = new Vector3(1,1,1);
```

### Functions
|              |                                                               |
|--------------|---------------------------------------------------------------|
| ToString     | Out puts a string of the vector                               |
| GetMagnitude | Returns the Magnitude					       |
| Normalize    | Normalizes a vector                                           |
| DotProduct   | Gets the dot product of this Objects vector to another vector |
| CrossProduct | Gets the cross product of This Vector to another              |
| Angle        | Gets the angle of this object to another object               |
| Distance     | Gets the distance from this objecto to another object         |

### Operators
|    |                                  |
|----|----------------------------------|
| == | Checks if Vectors are Equal      |
| != | Checks if Vectors are Not Equal  |
| +  | Adds two Vectors                 |
| -  | Subtracts two Vectors            |
| *  |  Multiply the Vector by a Scaler |
| /  | Divides the Vector by a Scaler   |

---

## Vector4

Represents four-deminsional vectors

### Properties

|||
|------------|------------------------------------|
| Magnitude  | Gets the length of the vector      |
| Normalized | Sets the length of the vector to 1 |

### Constructor
|         |                    |
|---------|--------------------|
| Vector3 |  Input a x , y , z , and w |

#### Example

```cs
Vector4 example = new Vector4(1,1,1,1);
```


### Functions
|              |                                                               |
|--------------|---------------------------------------------------------------|
| ToString     | Out puts a string of the vector                               |
| GetMagnitude | Returns the Magnitude					       |
| Normalize    | Normalizes a vector                                           |
| DotProduct   | Gets the dot product of this Objects vector to another vector |
| CrossProduct | Gets the cross product of This Vector to another              |
| Angle        | Gets the angle of this object to another object               |
| Distance     | Gets the distance from this objecto to another object         |

### Operators
|    |                                  |
|----|----------------------------------|
| == | Checks if Vectors are Equal      |
| != | Checks if Vectors are Not Equal  |
| +  | Adds two Vectors                 |
| -  | Subtracts two Vectors            |
| *  |  Multiply the Vector by a Scaler |
| /  | Divides the Vector by a Scaler   |

---

## Matrix3

A standard 3x3 Matrix

### Properties
|          |                           |
|----------|---------------------------|
| Identity | Returns a identity matrix |

### Constructor

|         |                 |
|---------|-----------------|
| Matrix3 | Input 9 numbers |

The inputs will be insterted by the row

#### Example
Inputing
```cs
Matrix3 matrix3 = new Matrix3(1,2,3,4,5,6,7,8,9);
```
Would make a matrix like
```cs
Matrix3 matrix3 = new Matrix3( 1, 2, 3, 
			       4, 5, 6, 
                               7, 8, 9);
```

### Funtions

|          |                                |
|----------|--------------------------------|
| ToString | Outputs the matrix as a string |

### Static Functions

|                   |                                        |
|-------------------|----------------------------------------|
| CreateTranslation | Creates a translation matrix           |
| CreateRotation    | Creates a Rotation matrix              |
| CreateScale       | Creates a Scale matrix                 |
| Transpose         | Swaps the rows and collums of a matrix |

### Operators

|   |                               |
|---|-------------------------------|
| + | Adds two matricies            |
| - | Subtracts two matricies       |
| * | Mulitply two matricies        |
| * | Multiply a Matrix by a Vector3 |

---

## Matrix4

A standard 4x4 matrix

### Properties
|          |                           |
|----------|---------------------------|
| Identity | Returns a identity matrix |

### Constructor

|         |                 |
|---------|-----------------|
| Matrix3 | Input 16 numbers |

The inputs will be insterted by the row

#### Example
Inputing
```cs
Matrix3 matrix3 = new Matrix3(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16);
```
Would make a matrix like
```cs
Matrix3 matrix3 = new Matrix3( 1,  2 , 3 , 4,
                               5,  6 , 7 , 8,
                               9,  10, 11, 12,
			       13, 14, 15, 16);
```

### Funtions

|          |                                |
|----------|--------------------------------|
| ToString | Outputs the matrix as a string |

### Static Functions

|                   |                                        |
|-------------------|----------------------------------------|
| CreateTranslation | Creates a translation matrix           |
| CreateRotation    | Creates a Rotation matrix              |
| CreateScale       | Creates a Scale matrix                 |
| Transpose         | Swaps the rows and collums of a matrix |

### Operators

|   |                               |
|---|-------------------------------|
| + | Adds two matricies            |
| - | Subtracts two matricies       |
| * | Mulitply two matricies        |
| * | Multiply a Matrix by a Vector4 |





