Lab3 (Specs)
1. Språkanpassning, svensk Feature-fil
Första raden: #language: sv-SE
2. Specfikation och automatisering (bindings) i separata assemblies.

DLL:en med automatiseringslagret (bindings, step definitions) måste refereras i specifikationsprojektet.
Avsnittet <stepAssemblies> måste läggas till i konfigurationen (app.config), se exempel nedan.
Feature-filen kan få problem att känna av att step-filen finns, d.v.s. fel färgkod i feature-filen.

---------------------------------------------------------------------------
Mer info om external assemblies

Se referens: http://specflow.org/documentation/Use-Bindings-from-External-Assemblies/
Use Bindings From External Assemblies
Bindings can be defined in the main SpecFlow project or in other assemblies (external binding assemblies). If the bindings are used from external binding assemblies, the following notes have to be considered:

The external binding assembly can be another project in the solution or an compiled library (dll).
The external binding assembly can also use a different .NET language, e.g. you can write bindings for your C# SpecFlow project also in F#. (As an extreme case, you can use your SpecFlow project with the feature files only and with all the bindings defined in external binding assemblies.)
The external binding assembly has to be referenced from the SpecFlow project to ensure it is copied to the target folder and listed in the app.config of the SpecFlow project (see below).
The external binding assemblies can contain all kind of bindings: step definition, hooks and also step argument transformations.
The bindings from assembly references are not fully supported in the Visual Studio integration of SpecFlow v1.8 or earlier: the step definitions from these assemblies will not be listed in the autocompletion lists.
The external binding file must be in the root of the project being referenced. If it is in a folder in the project, the bindings will not be found.
Configuration
In order to use bindings from an external binding assembly, you have to list it (with the assembly name) in the app.config of the SpecFlow project. The SpecFlow project is always included implicitly. See more details on the configuration in the <stepAssemblies> section of the configuration guide.

<specFlow>
  <stepAssemblies>
    <stepAssembly assembly="MySharedBindings" />
  </stepAssemblies>
</specFlow>
