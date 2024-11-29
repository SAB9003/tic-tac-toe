// See https://aka.ms/new-console-template for more information
Console.WriteLine("Yoy have opened the tic-tac-toe program");
//Всі зміні
char first_field = '1', second_field = '2', third_field = '3',
    fourth_field = '4', fifth_field = '5', sixth_field = '6',
    seventh_field = '7', eighth_field = '8', ninth_field = '9',
    player = 'X', choose_field;
bool not_game_over = true, who_won;
byte number_of_moves = 1,last_move=9;
while (number_of_moves <= last_move && not_game_over)
{
    //Блок виводу поля
    //Console.WriteLine($"\n{number_of_moves}\n");
    Console.WriteLine($"{first_field} | {second_field} | {third_field}");
    Console.WriteLine("-------");
    Console.WriteLine($"{fourth_field} | {fifth_field} | {sixth_field}");
    Console.WriteLine("-------");
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
            {
                if (first_field == '1')
                    first_field = player;
                else
                {
                    Console.WriteLine("This field is already taken");
                    number_of_moves--;
                }
                break;
            }
        case '2':
            {
                if (second_field == '2')
                    second_field = player;
                else
                {
                    Console.WriteLine("This field is already taken");
                    number_of_moves--;
                }
                break;
            }
        case '3':
            {
                if (third_field == '3')
                    third_field = player;
                else
                {
                    Console.WriteLine("This field is already taken");
                    number_of_moves--;
                }
                break;
            }
        case '4':
            {
                if (fourth_field == '4')
                    fourth_field = player;
                else
                {
                    Console.WriteLine("This field is already taken");
                    number_of_moves--;
                }
                break;
            }
        case '5':
            {
                if (fifth_field == '5')
                    fifth_field = player;
                else
                {
                    Console.WriteLine("This field is already taken");
                    number_of_moves--;
                }
                break;
            }
        case '6':
            {
                if (sixth_field == '6')
                    sixth_field = player;
                else
                {
                    Console.WriteLine("This field is already taken");
                    number_of_moves--;
                }
                break;
            }
        case '7':
            {
                if (seventh_field == '7')
                    seventh_field = player;
                else
                {
                    Console.WriteLine("This field is already taken");
                    number_of_moves--;
                }
                break;
            }
        case '8':
            {
                if (eighth_field == '8')
                    eighth_field = player;
                else
                {
                    Console.WriteLine("This field is already taken");
                    number_of_moves--;
                }
                break;
            }
        case '9':
            {
                if (ninth_field == '9')
                    ninth_field = player;
                else
                {
                    Console.WriteLine("This field is already taken");
                    number_of_moves--;
                }
                break;
            }
        default:
            Console.WriteLine("Fiend entred incorrectly");
            break;
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
Console.WriteLine("-------");
Console.WriteLine($"{fourth_field} | {fifth_field} | {sixth_field}");
Console.WriteLine("-------");
Console.WriteLine($"{seventh_field} | {eighth_field} | {ninth_field}");
if (not_game_over)
    Console.WriteLine("Draw");
else
{
    Console.WriteLine($"Player {player} won");
}
