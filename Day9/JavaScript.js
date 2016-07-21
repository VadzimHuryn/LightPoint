


var store = (function () {
    var products = [];

    function add(obj) {
        var i = +localStorage.getItem("maxKey")+1;
        localStorage.setItem(i, JSON.stringify({ id: i, name: obj.Name.value, description: obj.Description.value , price: obj.Price.value, count: obj.Count.value}));
        localStorage.setItem("maxKey", i);
        location.reload();
    }
    function get() {
        for (var i = 0; i <=localStorage.getItem("maxKey"); i++)
        {
            if(JSON.parse(localStorage.getItem(i))!=undefined)
            products.push(JSON.parse(localStorage.getItem(i)));
        }
        for(var item in products)
        {
                document.getElementById("table").innerHTML 
                    = document.getElementById("table").innerHTML +
                '<tr><td class="productTable">' + products[item].id + '</td><td class="productTable">' + products[item].name + '</td><td class="productTable">' + products[item].description + '</td><td class="productTable">' + products[item].price +
                '</td><td class="productTable">' + products[item].count + '</td><td class="productTableDelete"><input type="button"  id=' + products[item].id +
                '  onclick="store.DeleteItems(' + products[item].id + ');" value="[DEL]"></input></td> <td class="productTableDelete"><a href="UpdateItem.html?ID=' + products[item].id + '"><input type="button" value="[EDIT]"></button></a></td></tr>';
        }
    }
    function generateItems() {
        if (localStorage.length == 0) {
            for (var i = 0; i <=15; i++) {
                var product = JSON.stringify({ id: i, name: "Name" + i, description: " ?!?!", price: Math.pow(i + 1, i), count: i * 3 });
                localStorage.setItem(i, product);
            }
            localStorage.setItem("maxKey",i)
        }
    }
    function deleteItem(keyProduct) {
        if (keyProduct != undefined) {
            delete localStorage[keyProduct];
            location.reload();
        }
    }
    function updateItem(startItem) {
        localStorage.setItem(startItem.IDinput.value, JSON.stringify({ id: startItem.IDinput.value, name: startItem.Nameinput.value, description: startItem.Descriptioninput.value, price: startItem.Priceinput.value, count: startItem.Countinput.value }));
    }
    function sortItems() {
        if (products.length != undefined) {
            products.sort();
        }
    }
    function addtoinput(obj)
    {
        var a = JSON.parse(localStorage.getItem(obj));
        document.getElementById("ID").innerHTML = '<input type="text" hidden="hidden" name="IDinput"  value="' + a.id + '"/>';
        document.getElementById("Name").innerHTML = '<input type="text" name="Nameinput" value="' + a.name + '"/>';
        document.getElementById("Description").innerHTML = '<input type="text" name="Descriptioninput" value="' + a.description + '"/>';
        document.getElementById("Price").innerHTML = '<input type="text" name="Priceinput" value="' + a.price + '"/>';
        document.getElementById("Count").innerHTML = '<input type="text" name="Countinput" value="' + a.count + '"/>';
        
    }
    return {
        AddProduct: add,
        GetAllProducts: get,
        GenerateItems: generateItems,
        DeleteItems: deleteItem,
        UpdateItem: updateItem,
        SortItems: sortItems,
        AddToInput: addtoinput
    }
}
)();

store.GenerateItems();
store.GetAllProducts();










