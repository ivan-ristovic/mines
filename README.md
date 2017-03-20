# :sparkles: Minesweeper :sparkles:

![ss](https://raw.githubusercontent.com/ivan-ristovic/mines/master/screenshots/2017-03-20.PNG)

Coded in C# using Visual Studio 2017 RC.

## :page_facing_up: Game rules:
1. Uncover a mine, and the game ends.
2. Uncover an empty square, and you keep playing.
3. Uncover a number, and it tells you how many mines lay hidden in the eight surrounding squares — information you use to deduce which nearby squares are safe to click.

## :computer: Installation
For now the only way to actually run the program is to download the project and import it into your Visual Studio.

When I finish, I will add an installer or something.

## :video_game: Usage
| **Key** | **Description** |
| :---  | :--- |
| ```Left click``` | Uncover a cell |
| ```Right click``` | Toggle mine marker |

To start a new game you can either do it via menu, or by clicking on a smiley face (old school).

You can set the game parameters (mine number or field size) in Options menu.

## :bug: Known bugs
- On Windows 10, for some reason certain buttons need to be clicked more than once to be opened.
