# Word Scramble X

Word Scramble X is a C# Windows Forms arcade word game where the player unscrambles random words under pressure.

## Project Goals

- Load words from `words.txt`.
- Show one scrambled word at a time.
- Let the player type a guess and check it.
- Track attempts, failed guesses, solved words, score, streak, lives, words left, and high score.
- Support difficulty modes with different timers, lives, and score multipliers.
- Add arcade tools: hints, reshuffle, skip, new game, timer bar, and persistent high score.

## Technologies

- C#
- Windows Forms
- .NET 8

## How to Run

Open `WordScramble.sln` in Visual Studio, press `F5`, and play the game.

## Controls

- `Check` verifies the current guess.
- `Hint` reveals letters one at a time, but resets the streak and costs points.
- `Reshuffle` scrambles the same word again for a small point cost.
- `Skip` moves to a new word, resets the streak, and removes points.
- `New Game` restarts the run with the selected difficulty.
- `Chill`, `Classic`, and `Blitz` change the timer, lives, and score multiplier.
- The failed attempts box shows wrong guesses for the current word.
