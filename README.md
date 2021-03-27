[![LinkedIn][linkedin-shield]][linkedin-url]

<h3 align="center">Collections in .NET Core 5</h3>
<p align="justify">
    An implementation of a simple Console Application developed during the Beginning C# Collections Course at PluralSight. This course was used to revisit C# concepts and keep learning .NET 5.
    This solution is diveded in 5 projects:
</p>

[Array](Array): Simple array implementation that stores and list the Days of the Week and allow user to substitute/update the days of the week.

The other 4 projects Read the Pop by Largest Final.csv file and extract its information (Country name, code, population, and region):

[ReadFile](ReadFile) populates a Country array, and, then, show the first 10 countries in the CSV and its population.

[ReadFileList](ReadFileList) populates a Country List, show all countries in the CSV and its population and perform some insert and remove operations.

[ReadFileDictionaries](ReadFileDictionaries) populates a Country Dictionary, show all countries in the CSV and its population and allow to look up countries by code.

[ReadFileDictionaryOfLists](ReadFileDictionaryOfLists) populates a Dictionary where the country region is the dictionary key and the list of countries from that region are the stored data. Thus, it allows to look up countries by typing any region listed in the CSV file.

The ReadFile projects were adapted to separate its operations from Program.cs to CountryController. Moreover, the CsvReader.cs has its own interface (ICsvReader.cs) in order to decouple it from the CountryController.

For the sake of learning, each ReadFile project has its own CountryController, CsvReader and ICsvReader. The only resource shared throughout all projects is the Read the Pop by Largest Final.csv.

## Instalation
1. Clone the repo
    ```sh
    git clone https://github.com/mateuszanatta/BasicProjects_ReadFile-Collections.git
    ```

2. Go inside any Folder Project and run
    ```sh
    dotnet run
    ```

3. Then follow the instructions
    


[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/mateuszanatta/
