var a = [];

for(var i=0;i<=10000;i++)
{
    a.push(i);
}


function reverseArray(array) {
    var array2 = [];
    var arl = array.length - 1;
    for(var i=arl; i>=0; i--)
    {
        array2.push(array[i]);
    }
    return array2;
}
console.time("test1");
a = reverseArray(a);
console.timeEnd("test1");



function reverseArrayInPlace(array)
{
    var arl = array.length-1;
    for(var i=0; i<=(arl / 2);i++)
    {
        var objprom = array[arl - i];
        array[arl - i] = array[i];
        array[i] = objprom;
    }
    return array;
}
console.time("test2");
a = reverseArrayInPlace(a);
console.timeEnd("test2");