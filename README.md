# jSniff

jSniff is a javascript libary which helps you to sniff functions.
When function is sniffed its execution date and parameters are logged by jSniff.
In addition, a custom function can be injected to the sniffed function to execute before the original code.

## How to use

add script tag to your website:
---
```html
<script type="text/javascript" src="jSniff.js"></script>
```
-- hit <Enter>
-- hit <Enter>

#####sniff the function using:
#####jSniff.sniffify
----
```js
function (obj, funcName, sniffName, customFunc)
```

 - obj: The object on which the function exists (if it is a function declaration then use window)
 - funcName: The name of the function
 - sniffName: The name for the sniff. It is later used when retrieving the invocations data
 - customFunc: A custom function which will be executed prior to the original function's code

lets assume we have a function declaration as follows:
```js
function multiply(a,b){
    return a*b;
}
```

so to sniff it we execute:
```js
jSniff.sniffify(window, 'multiply', 'window_multiply', function() { console.log('hello jSniff');} );
```


#####retrieve sniffed data using:
#####jSniff.getInvocations
----
```js
function getInvocations (sniffName)
```
This method returns an array of invocations sniffed data. Invocation sniffed data is an object with two properties:
 - executionDate: Javascript Date object with the execution date.
 - params: Array of the execution parameters. Each element in array is an array for itself with two elements. First element is the name of the parameter and the second is its value

#####jSniff.getLastInvocation
----
```js
function getLastInvocation (sniffName)
```
This method returns the last execution sniffed data. the returned object has two properties:
 - executionDate: Javascript Date object with the execution date.
 - params: Array of the execution parameters. Each element in array is an array for itself with two elements. First element is the name of the parameter and the second is its value


#####jSniff.getInvocations
----
```js
function getLastInvocationParams (sniffName)
```
This method returns an array of the last execution parameters. Each element in the array is an array for itself with two elements. First element is the name of the parameter and the second is its value

