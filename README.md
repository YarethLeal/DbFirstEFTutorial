# DbFirstEFTutorial
Step 1: Create the project. 

Select the type of project
![DbFirstEF-Step_1](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/f02f0a34-726a-43e1-aea4-93e999bebc2b)
![DbFirstEF-Step_2](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/5a52eee0-0008-412a-bebc-d53efd7c6f45)
Select the framework version and type
![DbFirstEF-Step_3](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/11eb5678-7e4a-42ce-ac8f-54bcb96fa7d4)
![DbFirstEF-Step_4](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/c054f7a4-7d1c-437e-a3ca-a3c2b7909a6e)

Step 2: Import the packages

Enter the NuGet package manager
![DbFirstEF-Step_5](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/ba4e627c-7b7d-4c07-b85e-4409396e7ea6)
The database package must be the same as the database type where the script was used.
![DbFirstEF-Step_6](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/e82d07fe-b013-49e9-a718-739ecdf2f728)
These 2 packages are essential:
![DbFirstEF-Step_7](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/376e4eaa-8d65-4a73-961f-c847de8f9054)

Step 3: Generate models and database context
![DbFirstEF-Step_8](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/42bc4086-beff-4b90-a5dd-5bf4d452eb94)
The following command must be entered in the console:

   Scaffold-DbContext "Data Source={Server Name};Initial Catalog=DbFirstEFTutorial;Integrated Security=True; TrustServerCertificate=True;" 
   Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
   
The string format is:

   Scaffold-DbContext + Connection string + DB package + Folder where the models are generalized.
![DbFirstEF-Step_9](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/b67d2f9e-37a5-4856-9f41-8d48f658c37e)
![DbFirstEF-Step_10](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/e00fdc93-d57e-4df7-bd2b-68cafeb5fe5a)

Step 4: Correct sensitive information warning caused by database context

The text string in line 24 is passed to the appsettings.json file, and lines 9-11 and 22-24 are removed.
![DbFirstEF-Step_11](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/1d2a9ae1-304c-48b7-a593-6551442bb3ff)
![DbFirstEF-Step_12](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/415c064f-595d-4b24-9dbb-1547c0ae35a6)
Context is added to program.cs so that it can be recognized
![DbFirstEF-Step_13](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/5737ad99-3f6e-4279-bc2e-deeeeadd64d9)

Step 5: Creating views and controllers using Scaffolding
![DbFirstEF-Step_14](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/fcfef52f-aea2-48ae-92f9-452ce5f98170)
![DbFirstEF-Step_15](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/6ac7ba60-9bf4-4aa5-8cfe-a2677bf39553)
![DbFirstEF-Step_16](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/6f79492f-43fd-4385-969d-8c90eae19716)
![DbFirstEF-Step_17](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/9c0c1bfe-a2a4-42d6-8d7f-495070aa9c0f)
Files that are generated and end in Controller.cs are moved to the Controllers folder so that they can be recognized.
![DbFirstEF-Step_17_1](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/914e9e13-5a5c-4b10-abdf-bf2becbb6103)
The _Layout.cshtml navbar accesses are added to be able to access the generated views.
![DbFirstEF-Step_18](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/342ddc72-11ad-40bc-9676-fa4762450d19)

Resultados:
![DbFirstEF-Step_19](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/380e282e-12ac-4e90-88ce-1c6e18e00fa3)
![DbFirstEF-Step_20](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/1f37db23-af7b-406d-af0e-758c2ab11db6)
![DbFirstEF-Step_21](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/a279619f-ee66-4174-a9ce-01edf9c82d53)
![DbFirstEF-Step_22](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/e8d7d0f5-f849-4def-9c90-e3dee7923e19)
![DbFirstEF-Step_23](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/96d67663-a57c-4794-8e21-d5994007d7d9)
