function values () {
    var i = 0;
    var arg = arguments;
    function next() {
        if (arg[i] != undefined)
        {
            alert(arg[i]);
            i++;
        }
    }
    return {
        Next:next
    }
}

var a = values(1, 2, 3, 4, 5, 6, 7);
a.Next();
a.Next();
a.Next();
a.Next();
a.Next();
a.Next();
a.Next();
a.Next();

