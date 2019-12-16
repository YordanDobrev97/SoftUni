function needMoneyBuyFruit(type, weight, pricePerKg) {
      let totalMoney = weight * pricePerKg / 1000;
      let moneyPerKg = totalMoney / pricePerKg;

      console.log(`I need $${totalMoney.toFixed(2)} to buy ${moneyPerKg.toFixed(2)} kilograms ${type}.`);
}

needMoneyBuyFruit('orange', 2500, 1.80);
needMoneyBuyFruit('apple', 1563, 2.35);