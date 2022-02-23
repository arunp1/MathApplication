# MathApplication

This is a Console Application Where it will calculate the area and Perimeter of each shapes
FillAndAddToCollection Method is the place where we are inserting each shapes and its area and perimeter into Shape collection
Shape is the base class
All the shapes are inheriting the Shape class
All the shapes are added into the shapes class.
Area and Perimeter calculation is added in their respective classes
for eg : Area and perimeter calculation for Circle is inside the Circle class
There are 2 interfaces 1. ICommonShape which is being used by Circle and Quadrilaterals class . 2- ITriangleShape is for Triangle

Once the values are added into collection i am sorting the shapes based on Area and Perimeter. Logic is inside SortShapes method

Once the sorting is done i have added 2 types of serialization. XML and Json. Logic is inside DataSerialize method.

TrackClassObjectCount will return the the number of Shape objects created (per class).

