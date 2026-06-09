# Word Scramble

Word Scramble is a C# Windows Forms game where the player tries to unscramble random words from a text file.

## Project Goals

- Load words from `words.txt`.
- Show one scrambled word at a time.
- Let the player type a guess and check it.
- Track attempts, failed guesses, solved words, and score.
- Regenerate a new word after too many failed attempts.
- Add small extra features: skip, hint, scoring, and a countdown timer.

## Technologies

- C#
- Windows Forms
- .NET 8

## How to Run

Open `WordScramble.slnx` in Visual Studio, press `F5`, and play the game.

## Controls

- `Check` verifies the current guess.
- `Skip` moves to a new word and removes a few points.
- `Hint` reveals the first and last letter and removes a few points.
- The timer gives the player 30 seconds for each word.
- The failed attempts box shows wrong guesses for the current word.
