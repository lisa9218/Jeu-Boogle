// See https://aka.ms/new-console-template for more information
static void DecaleTableau(int[] tab, int valeur)
{
    int[] rep = null;
    int k = 0;
    if (tab != null || tab.Length != 0)
    {
        rep = new int[valeur];
        for (int i = 0; i < rep.Length; i++)
        {
            rep[i] = tab[i];
        }
        for (int j = 0; j < tab.Length - valeur; j++)
        {
            tab[j] = tab[j + valeur];
        }
        for (int i = tab.Length - valeur; i < tab.Length; i++)
        {
            tab[i] = rep[k];
            k++;
        }
        for (int i = 0; i < tab.Length; i++)
        {
            Console.Write(tab[i] + " ");
        }
    }

}

int[] tab = new int[] { 1, 2, 3, 4, 5, 6 };
DecaleTableau(tab, 2);
