# DependencyInjection
Understanding the dependency injection container used by Microsoft (Microsoft.Extensions.DependencyInjection)

See below. Running the app generates this output. Singleton instance is always the same. Transient instance is always different regardless the scope. Scoped instance is always the same whether the scope does not change. Note that at the end of the scope both Transient and Scoped instances are destroyed. 

```
Request 1
Singleton instance with Guid 47a9f3a0-da39-4cdc-a8f5-16d8dfe48d7c has been created at 03/03/2022 05:26:02
Scoped instance with Guid 236d4d96-0005-4210-8069-2ca99b875637 has been created at 03/03/2022 05:26:02
Transient instance with Guid 07353a57-d59a-4c59-bdcf-c0d46b0b0edf has been created at 03/03/2022 05:26:02
Singleton - Guid 47a9f3a0-da39-4cdc-a8f5-16d8dfe48d7c ; Created at 03/03/2022 05:26:02
Transient - Guid 07353a57-d59a-4c59-bdcf-c0d46b0b0edf ; Created at 03/03/2022 05:26:02
Scoped - Guid 236d4d96-0005-4210-8069-2ca99b875637 ; Created at 03/03/2022 05:26:02

Request 2 - Same scope
Transient instance with Guid 2849212f-6992-4c08-9093-d8546a35e910 has been created at 03/03/2022 05:26:02
Singleton - Guid 47a9f3a0-da39-4cdc-a8f5-16d8dfe48d7c ; Created at 03/03/2022 05:26:02
Transient - Guid 2849212f-6992-4c08-9093-d8546a35e910 ; Created at 03/03/2022 05:26:02
Scoped - Guid 236d4d96-0005-4210-8069-2ca99b875637 ; Created at 03/03/2022 05:26:02

Request 3 - Same scope
Transient instance with Guid 6a712257-0acd-49e4-a77a-1e3a7f8aa72f has been created at 03/03/2022 05:26:02
Singleton - Guid 47a9f3a0-da39-4cdc-a8f5-16d8dfe48d7c ; Created at 03/03/2022 05:26:02
Transient - Guid 6a712257-0acd-49e4-a77a-1e3a7f8aa72f ; Created at 03/03/2022 05:26:02
Scoped - Guid 236d4d96-0005-4210-8069-2ca99b875637 ; Created at 03/03/2022 05:26:02

Request 4 - Same scope
Transient instance with Guid f52bd345-ca17-4d57-9457-77bde8ba63cd has been created at 03/03/2022 05:26:02
Singleton - Guid 47a9f3a0-da39-4cdc-a8f5-16d8dfe48d7c ; Created at 03/03/2022 05:26:02
Transient - Guid f52bd345-ca17-4d57-9457-77bde8ba63cd ; Created at 03/03/2022 05:26:02
Scoped - Guid 236d4d96-0005-4210-8069-2ca99b875637 ; Created at 03/03/2022 05:26:02

Request 5 - Same scope
Transient instance with Guid 93caa2e9-32ed-4dde-b161-d8c469d88b07 has been created at 03/03/2022 05:26:02
Singleton - Guid 47a9f3a0-da39-4cdc-a8f5-16d8dfe48d7c ; Created at 03/03/2022 05:26:02
Transient - Guid 93caa2e9-32ed-4dde-b161-d8c469d88b07 ; Created at 03/03/2022 05:26:02
Scoped - Guid 236d4d96-0005-4210-8069-2ca99b875637 ; Created at 03/03/2022 05:26:02

Request 6 - Same scope
Transient instance with Guid 601af647-6c34-45c9-abf8-060b866aa340 has been created at 03/03/2022 05:26:02
Singleton - Guid 47a9f3a0-da39-4cdc-a8f5-16d8dfe48d7c ; Created at 03/03/2022 05:26:02
Transient - Guid 601af647-6c34-45c9-abf8-060b866aa340 ; Created at 03/03/2022 05:26:02
Scoped - Guid 236d4d96-0005-4210-8069-2ca99b875637 ; Created at 03/03/2022 05:26:02

Request 7 - Another scope
Scoped instance with Guid 865da2d0-b334-4f15-94d3-20939636776d has been created at 03/03/2022 05:26:02
Transient instance with Guid adc403b5-56b7-4790-aa19-14fe90160498 has been created at 03/03/2022 05:26:02
Singleton - Guid 47a9f3a0-da39-4cdc-a8f5-16d8dfe48d7c ; Created at 03/03/2022 05:26:02
Transient - Guid adc403b5-56b7-4790-aa19-14fe90160498 ; Created at 03/03/2022 05:26:02
Scoped - Guid 865da2d0-b334-4f15-94d3-20939636776d ; Created at 03/03/2022 05:26:02

Request 8 - Another scope
Transient instance with Guid ad826af9-8080-4327-b1d1-af2fef55d78e has been created at 03/03/2022 05:26:02
Singleton - Guid 47a9f3a0-da39-4cdc-a8f5-16d8dfe48d7c ; Created at 03/03/2022 05:26:02
Transient - Guid ad826af9-8080-4327-b1d1-af2fef55d78e ; Created at 03/03/2022 05:26:02
Scoped - Guid 865da2d0-b334-4f15-94d3-20939636776d ; Created at 03/03/2022 05:26:02

Request 9 - Another scope
Transient instance with Guid b6de0f3e-fb46-46d7-9b64-3d24a5e9f421 has been created at 03/03/2022 05:26:02
Singleton - Guid 47a9f3a0-da39-4cdc-a8f5-16d8dfe48d7c ; Created at 03/03/2022 05:26:02
Transient - Guid b6de0f3e-fb46-46d7-9b64-3d24a5e9f421 ; Created at 03/03/2022 05:26:02
Scoped - Guid 865da2d0-b334-4f15-94d3-20939636776d ; Created at 03/03/2022 05:26:02

Request 10 - Another scope
Transient instance with Guid 2addcf68-0c8f-4677-bbc5-454caf3927b2 has been created at 03/03/2022 05:26:02
Singleton - Guid 47a9f3a0-da39-4cdc-a8f5-16d8dfe48d7c ; Created at 03/03/2022 05:26:02
Transient - Guid 2addcf68-0c8f-4677-bbc5-454caf3927b2 ; Created at 03/03/2022 05:26:02
Scoped - Guid 865da2d0-b334-4f15-94d3-20939636776d ; Created at 03/03/2022 05:26:02

Request 11 - Another scope
Transient instance with Guid 0ed45493-6913-4473-9815-812a086f846b has been created at 03/03/2022 05:26:02
Singleton - Guid 47a9f3a0-da39-4cdc-a8f5-16d8dfe48d7c ; Created at 03/03/2022 05:26:02
Transient - Guid 0ed45493-6913-4473-9815-812a086f846b ; Created at 03/03/2022 05:26:02
Scoped - Guid 865da2d0-b334-4f15-94d3-20939636776d ; Created at 03/03/2022 05:26:02
Transient instance with Guid 0ed45493-6913-4473-9815-812a086f846b has been destroyed at 03/03/2022 05:26:02
Transient instance with Guid 2addcf68-0c8f-4677-bbc5-454caf3927b2 has been destroyed at 03/03/2022 05:26:02
Transient instance with Guid b6de0f3e-fb46-46d7-9b64-3d24a5e9f421 has been destroyed at 03/03/2022 05:26:02
Transient instance with Guid ad826af9-8080-4327-b1d1-af2fef55d78e has been destroyed at 03/03/2022 05:26:02
Transient instance with Guid adc403b5-56b7-4790-aa19-14fe90160498 has been destroyed at 03/03/2022 05:26:02
Scoped instance with Guid 865da2d0-b334-4f15-94d3-20939636776d has been destroyed at 03/03/2022 05:26:02
```
