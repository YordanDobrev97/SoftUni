function theatrePromotions(typeOfDay, age){
    price = 0;
    hasError = false;
    if (typeOfDay == "Weekday")
    {
        if (age >=0 && age <= 18)
        {
            price = 12;
        }
        else if (age > 18 && age <= 64)
        {
            price = 18;
        }
        else if(age > 64 && age <= 122)
        {
            price = 12;
        }
        else
        {
            hasError = true;
        }
    }
    else if(typeOfDay == "Weekend")
    {
        if (age >=0 && age <= 18)
        {
            price = 15;
        }
        else if (age > 18 && age <= 64)
        {
            price = 20;
        }
        else if (age > 64 && age <= 122)
        {
            price = 15;
        }
        else
        {
            hasError = true;
        }
    }
    else
    {
        if (age >= 0 && age <= 18)
        {
            price = 5;
        }
        else if (age > 18 && age <= 64)
        {
            price = 12;
        }
        else if (age > 64 && age <= 122)
        {
            price = 10;
        }
        else
        {
            hasError = true;
        }
    }

    if (hasError)
    {
        console.log("Error!");
    }
    else
    {
        console.log(`${price}$`);
    }
}

theatrePromotions('Weekday', 42);