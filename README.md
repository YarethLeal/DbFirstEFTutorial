# DbFirstEFTutorial
Step 1: Create the project. 

Select the type of project

![DbFirstEF-Step_1](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/7c23b256-59dd-48ae-b6e1-c714dadc3b88)

![DbFirstEF-Step_2](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/da0aa81b-5c79-4e6c-a0fb-0bf10ede0b54)

Select the framework version and type

![DbFirstEF-Step_3](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/dc523b86-8b05-4a50-9e53-3f6ad04c79d8)

![DbFirstEF-Step_4](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/20e1d499-31b3-4d3e-91c0-e0ea21c598a0)

Step 2: Import the packages

Enter the NuGet package manager

![DbFirstEF-Step_5](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/a3d6223c-7127-4829-bb94-8a0fce697760)

The database package must be the same as the database type where the script was used.

![DbFirstEF-Step_6](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/abd60c23-b8eb-4ae0-a313-0f5f0d534ff2)

These 2 packages are essential:

![DbFirstEF-Step_7](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/5b8f90f2-04ef-4c31-8b92-c202c9ef5344)

Step 3: Generate models and database context

![DbFirstEF-Step_8](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/ba6ac21b-030c-4fe1-84b2-a2091ba6d8ef)

The following command must be entered in the console:

   Scaffold-DbContext "Data Source={Server Name};Initial Catalog=DbFirstEFTutorial;Integrated Security=True; TrustServerCertificate=True;" 
   Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
   
The string format is:

   Scaffold-DbContext + Connection string + DB package + Folder where the models are generalized.
   
![DbFirstEF-Step_9](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/d0b04b1d-33e4-41ea-911f-3cdbea190a9c)

![DbFirstEF-Step_10](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/f37735c1-bedd-411d-a99a-533558c0afed)

Step 4: Correct sensitive information warning caused by database context

The text string in line 24 is passed to the appsettings.json file, and lines 9-11 and 22-24 are removed.

![DbFirstEF-Step_11](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/cbb4a7c5-2b54-47dd-a730-57981d271ac1)

![DbFirstEF-Step_12](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/8ae69045-ede2-4d68-b994-9f27e298637e)

Context is added to program.cs so that it can be recognized

![DbFirstEF-Step_13](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/3ae9f030-8c92-4152-b8e7-e150a2a337be)

Step 5: Creating views and controllers using Scaffolding

![DbFirstEF-Step_14](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/cc850cc1-9b2a-4787-b4cc-29b6ad22e97a)

![DbFirstEF-Step_15](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/6df3625a-77a4-4930-ba10-24e0beee400a)

![DbFirstEF-Step_16](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/e313fd00-0b4a-4712-abb8-0f5d6b40ca92)

![DbFirstEF-Step_17](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/7caa473c-92b3-49ba-8218-7a525839817a)

Files that are generated and end in Controller.cs are moved to the Controllers folder so that they can be recognized.

![DbFirstEF-Step_17_1](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/5caf9541-05b1-4cc3-a88d-32315986f8c4)

The _Layout.cshtml navbar accesses are added to be able to access the generated views.

![DbFirstEF-Step_18](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/8ba56413-4eb3-422e-9192-a1b664527157)

Resultados:

![DbFirstEF-Step_19](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/9ced97e9-d922-4104-a27e-22d14f21643a)

![DbFirstEF-Step_20](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/f13117cf-a531-4819-b1d5-d1cce296aab3)

![DbFirstEF-Step_21](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/5fc2379c-f944-4b70-a5b8-df2dba0bd0d2)

![DbFirstEF-Step_22](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/0b4e5e53-b93a-4fe1-af12-aa62d00e336d)

![DbFirstEF-Step_23](https://github.com/YarethLeal/DbFirstEFTutorial/assets/66440902/3cf034d9-07df-4dc9-8641-6649b1cbe9af)
