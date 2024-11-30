// See https://aka.ms/new-console-template for more information
Console.WriteLine("Yoy have opened the tic-tac-toe program");
//Всі зміні
char first_field = '1', second_field = '2', third_field = '3',
    fourth_field = '4', fifth_field = '5', sixth_field = '6',
    seventh_field = '7', eighth_field = '8', ninth_field = '9',
    player = 'X', choose_field, selected_field =' ';
bool not_game_over = true, who_won;
byte number_of_moves = 1,last_move=9;
while (number_of_moves <= last_move && not_game_over)
{
    //Блок виводу поля
    Console.WriteLine($"{first_field} | {second_field} | {third_field}");
    Console.WriteLine("----------");
    Console.WriteLine($"{fourth_field} | {fifth_field} | {sixth_field}");
    Console.WriteLine("----------");
    Console.WriteLine($"{seventh_field} | {eighth_field} | {ninth_field}");
    if (number_of_moves % 2 == 0)
        player = 'O';
    else
        player = 'X';
    Console.WriteLine($"Player {player} walks choose the field where you want to go:");
    choose_field = Console.ReadKey().KeyChar;
    Console.WriteLine("");
    switch (choose_field)
    {
        case '1': 
            selected_field = first_field; break;
        case '2': 
            selected_field = second_field; break;
        case '3': 
            selected_field = third_field; break;
        case '4': 
            selected_field = fourth_field; break;
        case '5': 
            selected_field = fifth_field; break;
        case '6': 
            selected_field = sixth_field; break;
        case '7': 
            selected_field = seventh_field; break;
        case '8': 
            selected_field = eighth_field; break;
        case '9': 
            selected_field = ninth_field; break;
        default:
            Console.WriteLine("Field entered incorrectly");
            continue;
    }
    if (selected_field == 'X' || selected_field == 'O')
    {
        Console.WriteLine("This field is already taken");
        continue;
    }
    switch (choose_field)
    {
        case '1':
            {
            first_field = player;
            break;
            }
        case '2':
            {
            second_field = player;
            break;
            }
        case '3':
            {
            third_field = player;
            break;
            }
        case '4':
            {
            fourth_field = player;
            break;
            }
        case '5':
            {
            fifth_field = player;
            break;
            }
        case '6':
            {
            sixth_field = player;
            break;
            }
        case '7':
            {
            seventh_field = player;
            break;
            }
        case '8':
            {
            eighth_field = player;
            break;
            }
        case '9':
            {
            ninth_field = player;
            break;
        }
    }
    //Перевірка по горизонталі
    if ((first_field == second_field && second_field == third_field) ||
        (fourth_field == fifth_field && fifth_field == sixth_field) ||
        (seventh_field == eighth_field && eighth_field == ninth_field))
        not_game_over = false;

    // Перевірка по вертикалі
    if ((first_field == fourth_field && fourth_field == seventh_field) ||
        (second_field == fifth_field && fifth_field == eighth_field) ||
        (third_field == sixth_field && sixth_field == ninth_field))
        not_game_over = false;

    // Перевірка по діагоналі
    if ((first_field == fifth_field && fifth_field == ninth_field) ||
        (third_field == fifth_field && fifth_field == seventh_field))
        not_game_over = false;
    number_of_moves++;
}
Console.WriteLine($"{first_field} | {second_field} | {third_field}");
Console.WriteLine("----------");
Console.WriteLine($"{fourth_field} | {fifth_field} | {sixth_field}");
Console.WriteLine("----------");
Console.WriteLine($"{seventh_field} | {eighth_field} | {ninth_field}");
if (not_game_over)
    Console.WriteLine("Draw");
else
{
    Console.WriteLine($"Player {player} won");
}
