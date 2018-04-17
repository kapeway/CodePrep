var privateFib = function(value){
    if(value == 0)
        return 0;
    else if(value == 1)
        return 1;    
    else
        return privateFib(value-1) + privateFib(value-2);
};

exports.fib=privateFib;