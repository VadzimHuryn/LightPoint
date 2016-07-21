Array.prototype.each = function (arg) {
    for (var i = 0; i < this.length; i++)
    {
        arg(this[i]);
    }
}

var a = Array(1,2,3,4,5,6);
a.each(function (argum) { argum = argum + 1; alert(argum); });
