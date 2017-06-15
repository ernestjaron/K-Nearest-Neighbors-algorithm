# K-Nearest-Neighbors-algorithm
An application for classication dataset based on k-nearest neighbors algorithm.
The input data has two atrributes: 'Label' (String) and 'attributes' (Double []). 
Any object is representing by this two fields. Any object has one label and one array of attributes. 
Array 'attributes 'contains 4 elements representing characteristics of object - sepal width, sepal length, petal width and petal length.
Firstly we have to load data from textfile - learning , and testing sets. 
Elements are placed into list that represents specific objects - for example 'Iris-Setosa' element will be placed into 'setosa' list, 'Iris-virginica' into 'virginica_list'
Data in testing file must have label describes as '?'. 
If we have testing and learning data we could to start algorithm - app allows using three metrics - Manhatan, Eucldean and Chebyshev distance.
In 'Program' class you could example : 
dist.Winner(fm.setosa[0], 3) - that means we want to choose 3 nearest neighbors for [0] ( so first element :) ). 
Type of metrics you could change in 'Distance' class in 'Winner' method - line 99. 
