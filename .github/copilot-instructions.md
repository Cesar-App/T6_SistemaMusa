# Copilot Instructions

## Directrices del proyecto
- Cuando crees archivos en el workspace, añádelos automáticamente a los .csproj correspondientes.
- Implementar o generar un script/automatización que:
  - Inserte entradas <Compile Include="..."/> para los archivos añadidos.
  - Añada <ProjectReference Include="..."/> cuando sea necesario.
  - Evite duplicados y detecte la ubicación correcta dentro del .csproj