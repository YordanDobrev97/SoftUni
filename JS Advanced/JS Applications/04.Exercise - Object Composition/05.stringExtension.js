(function extendString() {
  String.prototype.ensureStart = function(str) {
    if (!this.startsWith(str)) {
      return `${str}${this}`;
    }
    return `${this}`;
  };

  String.prototype.ensureEnd = function(str) {
    if (!this.endsWith(str)) {
      return `${this}${str}`;
    }
    return `${this}`;
  };

  String.prototype.isEmpty = function() {
    return this.length === 0;
  };

  String.prototype.truncate = function(n) {
    if (n < 4) {
      return `${".".repeat(n)}`;
    }

    if (n >= this.length) {
      return this.toString();
    }

    if (n < this.length) {
      const subPart = this.substr(0, n - 2);
      const lastSpace = subPart.lastIndexOf(" ");

      if (lastSpace !== -1) {
        const result = this.substr(0, lastSpace).concat("...");
        return result;
      }

      return this.substr(0, n - 3).concat("...");
    }
  };

  String.format = function(string, ...params) {
    for (let param of params) {
      let openBracketIndex = string.indexOf("{");
      let closedBracketIndex = string.indexOf("}");
      if (openBracketIndex !== -1 && closedBracketIndex !== -1) {
        const substring = string.substring(
          openBracketIndex,
          closedBracketIndex + 1
        );
        string = string.replace(substring, param);
      }
    }
    return string;
  };
})();
