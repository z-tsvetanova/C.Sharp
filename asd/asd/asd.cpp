
#include <iostream>
using namespace std;
struct tree                                //Struktura na durvo
{
    int value; tree *left, *right;        //Ukazatel koito sochi lqvoto i dqsnoto poddurvo
}   *root = NULL;                         //Ukazatel root kum korena na durvoto s inicializaciq NULL
void insert(int element, tree *&r)        //Funkciq insert dobavq element v durvoto
{
    if (r == NULL)  //Proverka ako durvoto ne sochi nikude durvoto e prazno
    {
        r = new tree();  //Root sochi nqkoq kletka ot pametta
        r->left = NULL;  //Zadavame stoinost na lqvoto poddurvo da e null
        r->right = NULL; //Zadavame stoinost na dqsnoto poddurvo da e null
        r->value = element; 
    }
    else    //Vlizame tuk ako imame koren
    {
        if (element < r->value)  //Proverka ako stoinostta e po-malka ot korena
        {
            insert(element, r->left);   //Vikame rekursivno funkciqta insert i v zavisimost na dobavqniq element otivame nalqvo
        }
        else
        {
            insert(element, r->right);  //Vikame rekursivno funkciqta insert i v zavisimost na dobavqniq element otivame nadqsno
        }
    }
}
int getDepth(tree* r) //Funkciq koqto izchislqva visochinata na durvo
{
    if (!r)
    {
        return -1;  //Ako durvoto e prazno negovata visochina e -1
    }
    else
    {
        int leftDepth = getDepth(r->left);  //Izchislqvame visochinata na lqvoto poddurvo
        int rightDepth = getDepth(r->right);  //Izchislqvame visochinata na dqsnoto poddurvo
        return leftDepth > rightDepth ? leftDepth + 1 : rightDepth + 1;  //Vrushta po-golqmata ot visochiite na lqvoto i dqsnoto poddurvo uvelicheno s 1 
    }
}
bool BalanceCheck(tree* r) {  //Funckiq koqto proverqva durvoto dali e balansirano
    static int counter = 0;   //Zapisva se visochinata na durvoto
    static int previousleaf = 0;  //Broqch koito pazi stoinostta na predishnoto listo
    static bool result = true;

    if (r) {  //Proverka dali durvoto ne e prazno
        if (r->left != nullptr || r->right != nullptr) {  //Proverqvame dali ne e listo
            if (r->left) {  //Proverka dali korena ima lqv naslednik ako ima otiva nalqvo
                counter++;  
                BalanceCheck(r->left);   //Vikame rekursivno funkciqta i otivame nalqvo
                counter--;   //Vrushtame se nazad
            }
            if (r->right) {  //Proverka dali korena ima lqv naslednik ako ima otiva nadqsno
                counter++;
                BalanceCheck(r->right);  //Vikame rekursivno funkciqta i otivame nadqsno
                counter--;//Vrushtame se nazad
            }
        }
        else {
            if (previousleaf == 0)  
            {
                previousleaf = counter;  //Proverka ako stoinostta na predishnoto listo e ravna na visochinata na durvoto
            }
            else
            {
                if (previousleaf != counter )  //Proverka ako stoinostta na predishnoto listo e razlichno ot visochinata na durvoto
                {
                    result = false;
                }
            }
        }
    }
    return result;
}
int main()
{   
    int n;  //Broq na elementite koito potrebitelq shte vuvede za razmer na masiva
    cout << "Enter the number of elements in the array: ";
    cin >> n;  //Vuvejda N ot klaviaturata
    int *array = new int[n]; //Dinamichen masiv ot celi chisla opredelen ot masiva N
    for (int i = 0; i < n; i++)  //Obhojdane na masiva
   {
        array[i] = rand() % 1000;  //Generira sluchaino chislo i go zapazva na poziciq i v masiva
        cout << array[i] << " ";  //Otpechatvane na masiva
    }
    for (int i = 0; i < n; i++)
    {
        insert(array[i], root);  //Dobavq masiva v durvovidna struktura
    }
    cout << endl;
    cout << "Depth of tree   : " << getDepth(root) << endl;
    cout << "Balance of tree : ";
    if (!BalanceCheck(root)) //Proverka ako durvoto e balansirano
    {  
        int left = getDepth(root->left);  //Izchislqva dulbochinata na lqvoto poddurvo na korena 
        int right = getDepth(root->right);  //Izchislqva dulbochinata na dqsnoto poddurvo na korena
        if (root->left > root->right) //Proverka ako lqvoto durvo e po-dulboko ot dqsnoto e neobhodimo da se napravi dqsna rotaciq
        {
            cout << "Need right rotation";
        }
        else 
        {
            cout << "Need left rotation";
        }
    }
}



