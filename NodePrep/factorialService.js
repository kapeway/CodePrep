var privateFact=function(value){
    if(value == 0 || value == 1)
        return 1;
    else
        return privateFact(value-1) * value;     
}

exports.fact=privateFact;