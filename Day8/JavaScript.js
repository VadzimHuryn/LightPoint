var store = createStore();
store.generateItems();
alert("Элементы сгенерированы");
store.get();
store.deleteItem(3, 2);
store.get();



function createStore() {
    var products = [];
    return {
        add: function(addItem)
        {
             products.push(addItem)
        },
        get: function()
        {
            for(var item in products)
            {
                alert(products[item].id +' ' + products[item].name + ' ' + products[item].cost);
            }
        },
        generateItems: function()
        {
            if(products.length==0)
            {
                for(var i=0; i<10; i++)
                {
                    products.push({id: i, name: 'Name '+1, cost: Math.pow(i+1, i)})
                }
            }
        },
        deleteItem: function(startItem, countItem)
        {
            if(startItem!=undefined && countItem!=undefined)
            {
                products.splice(startItem, countItem);
            }
        },
        updateItem: function(startItem, newItem)
        {
            if(startItem!=undefined && newItem!=undefined)
            {
                products.splice(startItem, 1, newItem);
            }
        },
        sortItems: function()
        {
            if(products.length!=undefined)
            {
                products.sort();
            }
        },
        AllProducts: products
    }  
}



