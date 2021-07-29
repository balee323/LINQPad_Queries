<Query Kind="Program" />


//enum thing
enum CategoryIndex
{
	Rock,
	Paper,
	Sissors
}

int[] categories = {0,0,0}; //length of 3

void Main()
{

	AddCategories(CategoryIndex.Rock);
	AddCategories(CategoryIndex.Paper);
    AddCategories(CategoryIndex.Rock);
	AddCategories(CategoryIndex.Rock);
	AddCategories(CategoryIndex.Sissors);
	;
}

void AddCategories(CategoryIndex ci)
{
	categories[(int)ci]++;
}











