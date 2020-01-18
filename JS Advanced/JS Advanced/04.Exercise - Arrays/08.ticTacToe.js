function ticTacToe(input) {
  let board = [
    [false, false, false],
    [false, false, false],
    [false, false, false]
  ];

  let index = 0;
  const firstPlayer = "F";
  const secondPlayer = "S";
  const maxCountMoved = 9;

  let winPlayer = undefined;
  let currentPlayer = firstPlayer;
  let countMoved = 0;

  let printBoard = () => {
    for (let row = 0; row < board.length; row++) {
      const elements = board[row];
      console.log(elements.join("	"));
    }
  };

  while (true) {
    //Nobody wins
    if (countMoved === maxCountMoved) {
      console.log("The game ended! Nobody wins :(");
      printBoard();
      break;
    }
    const playerCoordinates = input[index].split(" ");
    const row = Number(playerCoordinates[0]);
    const col = Number(playerCoordinates[1]);

    if (currentPlayer === firstPlayer && !board[row][col]) {
      board[row][col] = "X";
    } else if (currentPlayer === secondPlayer && !board[row][col]) {
      board[row][col] = "O";
    } else {
      console.log("This place is already taken. Please choose another!");
      index++;
      continue;
    }

    if (hasWin()) {
      console.log(`Player ${winPlayer} wins!`);
      printBoard();
      break;
    }

    if (currentPlayer === firstPlayer) {
      currentPlayer = secondPlayer;
    } else {
      currentPlayer = firstPlayer;
    }
    index++;
    countMoved++;
  }

  function hasWin() {
    if (isWinPlayer("X")) {
       return true;
    }

    if (isWinPlayer("O")) {
       return true;
    }
    return false;
  }
  function markHasWinner(count, maxCountForWin, player) {
    if (count === maxCountForWin) {
      winPlayer = player;
      return true;
    }
    return false;
  }

  function isWinPlayer(player) {
    const maxCountForWin = 3;
    let count = 0;
    //check diagonal winner
    /*
        X, X, X
    */
    for (let row = 0; row < board.length; row++) {
      const elements = board[row];
      for (let item of elements) {
        if (item !== player) {
          break;
        }
        count++;
      }

      if (markHasWinner(count, maxCountForWin, player)) {
        return true;
      }
    }

    //check row winner
    /*
        X
        X
        X
    */
    count = 0; //reset
    for (let row = 0; row < board.length; row++) {
      const element = board[row][0];

      if (element === player) {
        winPlayer = player;
        count++;
      }
    }

    if (markHasWinner(count, maxCountForWin, player)) {
      return true;
    }

    //first diagonal
    /*
        X  
           X       
              X
    */
    count = 0;

    for (let row = 0; row < board.length; row++) {
      const element = board[row][row];

      if (element === player) {
        winPlayer = player;
        count++;
      }
    }

    if (markHasWinner(count, maxCountForWin, player)) {
      return true;
    }

    //second diagonal
    /*
             X
          X
       X
    */

    let row = 0;
    for (let i = board.length - 1; i >= 0; i--) {
      const element = board[row][i];
      if (element === player) {
        winPlayer = player;
        count++;
      }
      row++;
    }

    // if (markHasWinner(count, maxCountForWin, player)) {
    //   return true;
    // }

    return false;
  }
}
// ticTacToe(["0 1",
// "0 0",
// "0 2", 
// "2 0",
// "1 0",
// "1 1",
// "1 2",
// "2 2",
// "2 1",
// "0 0"]
// );
