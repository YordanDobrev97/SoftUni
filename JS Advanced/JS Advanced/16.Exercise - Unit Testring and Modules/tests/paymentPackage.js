const expect = require("chai").expect;
const PaymentPackage = require("../06.PaymentPackage/paymentPackage.js");

describe("test class PaymentPackage", () => {
  it("test constructor with one parameter - throw exception", () => {
    const payment = () => {
      new PaymentPackage("HR Services");
    };
    expect(payment).to.throw("");
  });

  it("test constructor correctly parameters", () => {
    const payment = new PaymentPackage("HR Services", 1500);
    expect(payment._name).to.be.equal("HR Services");
    expect(payment.value).to.be.equal(1500);
  });

  it("set number value of name - throw exception", () => {
    const payment = () => {
      new PaymentPackage(123, 10);
    };
    expect(payment).to.throw("");
  });

  it("set name with length zero - throw exception", () => {
    const payment = () => {
      new PaymentPackage("", 1);
    };
    expect(payment).to.throw("");
  });

  it("set name successfully", () => {
    const payment = new PaymentPackage("sleep", 800);
    payment.name = "Consultation";
    expect(payment.name).to.be.equal("Consultation");
  });

  it("set incorrectly value for VAT - throw exception", () => {
    const payment = new PaymentPackage("Consultation", 3000);
    const vat = () => {
      payment.VAT = [];
    };
    expect(vat).to.throw("VAT must be a non-negative number");
  });

  it("set negative value for VAT - throw exception", () => {
    const payment = new PaymentPackage("Consultation", 3000);
    const vat = () => {
      payment.VAT = -10;
    };
    expect(vat).to.throw("VAT must be a non-negative number");
  });

  it("set VAT successfully", () => {
    const payment = new PaymentPackage("HR Services", 1000);
    payment.VAT = 30;
    expect(payment.VAT).to.be.equal(30);
  });

  it("set invalid value of active - throw exception", () => {
    const payment = new PaymentPackage("Consultation", 3000);
    const active = () => {
      payment.active = null;
    };
    expect(active).to.throw("Active status must be a boolean");
  });

  it("set valid value of active", () => {
    const payment = new PaymentPackage("Consultation", 3000);
    payment.active = false;
    expect(payment.active).to.be.equal(false);
  });

  it ('test default value of active', () => {
    const payment = new PaymentPackage("Consultation", 3000);
    expect(payment.active).to.be.equal(true);
  })

  it("test toString", () => {
    const payment = new PaymentPackage("Partnership Fee", 4000);
    const result = payment.toString();
    expect(result).to.be.equal(
      "Package: Partnership Fee\n- Value (excl. VAT): 4000\n- Value (VAT 20%): 4800"
    );
  });

  it ('test toString with false active value', () => {
    const payment = new PaymentPackage("Partnership Fee", 4000);
    payment.active = false;
    const result = payment.toString();
    expect(result).to.be.equal(
      "Package: Partnership Fee (inactive)\n- Value (excl. VAT): 4000\n- Value (VAT 20%): 4800"
    );
  });
});