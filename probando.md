# Ejemplo Mermaid - Flujo de Login

```mermaid
flowchart TD
    A[Usuario abre app] --> B{¿Está logueado?}
    B -- Sí --> C[Mostrar dashboard]
    B -- No --> D[Mostrar login]
    D --> E[Usuario ingresa datos]
    E --> F{¿Credenciales válidas?}
    F -- Sí --> C
    F -- No --> G[Mostrar error]
    G --> D