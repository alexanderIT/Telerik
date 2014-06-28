## Multidimensional Arrays

1. Write a program which fills and prints a matrix of size (n, n) as shown below: (examples for N = 4)
  * a)
<table>
    <tr>
        <td>1</td>
        <td>5</td>
        <td>9</td>
        <td>13</td>
    </tr>
    <tr>
        <td>2</td>
        <td>6</td>
        <td>10</td>
        <td>14</td>
    </tr>
    <tr>
        <td>3</td>
        <td>7</td>
        <td>11</td>
        <td>15</td>
    </tr>
    <tr>
        <td>4</td>
        <td>8</td>
        <td>12</td>
        <td>16</td>
    </tr>
</table>
	* b)
<table>
    <tr>
        <td>1</td>
        <td>8</td>
        <td>9</td>
        <td>16</td>
    </tr>
    <tr>
        <td>2</td>
        <td>7</td>
        <td>10</td>
        <td>15</td>
    </tr>
    <tr>
        <td>3</td>
        <td>6</td>
        <td>11</td>
        <td>14</td>
    </tr>
    <tr>
        <td>4</td>
        <td>5</td>
        <td>12</td>
        <td>13</td>
    </tr>
</table>
	* c)
<table>
    <tr>
        <td>7</td>
        <td>11</td>
        <td>14</td>
        <td>16</td>
    </tr>
    <tr>
        <td>4</td>
        <td>8</td>
        <td>12</td>
        <td>15</td>
    </tr>
    <tr>
        <td>2</td>
        <td>5</td>
        <td>9</td>
        <td>13</td>
    </tr>
    <tr>
        <td>1</td>
        <td>3</td>
        <td>6</td>
        <td>10</td>
    </tr>
</table>
	* d)*
<table>
    <tr>
        <td>1</td>
        <td>12</td>
        <td>11</td>
        <td>10</td>
    </tr>
    <tr>
        <td>2</td>
        <td>13</td>
        <td>16</td>
        <td>9</td>
    </tr>
    <tr>
        <td>3</td>
        <td>14</td>
        <td>15</td>
        <td>8</td>
    </tr>
    <tr>
        <td>4</td>
        <td>5</td>
        <td>6</td>
        <td>7</td>
    </tr>
</table>
* Write a program which reads a rectangular matrix of size N x M and finds in it the 3x3-square whose elements have a maximum sum.
* You are given a matrix of strings of size N x M. *Sequences* in the matrix are defined as sets of neighbor elements located on the same line, column or diagonal. Write a program which finds the longest sequence of equal strings in the matrix. Example:
<table>
    <tr>
        <td>`ha`</td>
        <td>fifi</td>
        <td>ho</td>
        <td>hi</td>
    </tr>
    <tr>
        <td>fo</td>
        <td>`ha`</td>
        <td>hi</td>
        <td>xx</td>
    </tr>
    <tr>
        <td>xxx</td>
        <td>ho</td>
        <td>`ha`</td>
        <td>xx</td>
    </tr>
</table>
  -> ha, ha, ha
<table>
    <tr>
        <td>s</td>
        <td>qq</td>
        <td>`s`</td>
    </tr>
    <tr>
        <td>pp</td>
        <td>pp</td>
        <td>`s`</td>
    </tr>
    <tr>
        <td>pp</td>
        <td>qq</td>
        <td>`s`</td>
    </tr>
</table>
  -> s, s, s
* Write a program which reads from the console an array of `N` integers and an integer `K`, sorts the array and using the method `Array.BinarySearch()` finds the largest number in the array which is ≤ K.
* You are given an array of strings. Write a method that sorts the array by the length of its elements.
* \* Write a class *Matrix* which holds a matrix of integers. Overload the operators for addition, subtraction and multiplication of matrices, indexer for accessing the matrix elements and override the method `ToString()`.
* \* Write a program which finds the largest area of equal neighbor elements in a rectangular matrix and prints its size.
 * Example:
 <table>
   <tr>
	<td>1</td>
	<td>`3`</td>
	<td>2</td>
	<td>2</td>
	<td>2</td>
	<td>4</td>
   </tr>
   <tr>
	<td>`3`</td>
	<td>`3`</td>
	<td>`3`</td>
	<td>2</td>
	<td>4</td>
	<td>4</td>
   </tr>
   <tr>
	<td>4</td>
	<td>`3`</td>
	<td>1</td>
	<td>2</td>
	<td>`3`</td>
	<td>`3`</td>
   </tr>
   <tr>
	<td>4</td>
	<td>`3`</td>
	<td>1</td>
	<td>`3`</td>
	<td>`3`</td>
	<td>1</td>
   </tr>
   <tr>
	<td>4</td>
	<td>`3`</td>
	<td>`3`</td>
	<td>`3`</td>
	<td>1</td>
	<td>1</td>
   </tr>
 </table>
 Hint: You can use the algorithms *depth-first search (DFS)* or *breadth-first search (BFS)*.