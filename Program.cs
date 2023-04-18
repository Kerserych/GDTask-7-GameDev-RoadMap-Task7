Console.WriteLine(String.Join(" ", getABC(20)));


int[] getABC(int num)
{
    int[] ret = new int[3];
    ret[0] = getA(num - 1);
    ret[1] = getB(num - 1);
    ret[2] = getC(num - 1);
    return ret;
}

int getA(int n)
{
    if ((n % 3 == 0) & (n % 5 != 0))
    {
        return n;
    }
    else
    {
        return getA(n - 1);
    }
}

int getB(int n)
{
    if ((n % 3 != 0) & (n % 5 == 0))
    {
        return n;
    }
    else
    {
        return getB(n - 1);
    }
}

int getC(int n)
{
    if ((n % 3 == 0) & (n % 5 == 0))
    {
        return n;
    }
    else
    {
        return getC(n - 1);
    }
}