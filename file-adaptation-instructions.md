# Per-File Business Adaptation Plan

## Scope
- Reference feature: APayment
- Target feature: GPayment
- Purpose: convert the generated scaffold from structural copy into target-domain business logic.
- Safety: review each file manually; do not modify project files or global configuration unless explicitly approved.

## Requirement Context
### Chunk 1: Requirement
Create a new GPayment feature similar to APayment.
The new feature should follow the same folder structure, naming style, controller pattern, mapper pattern, processor pattern, service pattern, dependency module pattern, error handling pattern, and unit test style used by APayment.

### Chunk 2: The GPayment feature should support
- Creating or processing a GPayment payment request.
- Validating account information.
- Validating payment amount.
- Mapping incoming request data to the internal payment operation request.
- Calling the payment processor/service layer asynchronously where the reference feature does so.
- Returning a structured payment response.
- Handling success, rejected payment, validation failure, and dependency failure using the existing APayment-style error handling pattern.
- Adding unit tests for controller, mapper, processor, manager, service, updater, and error handling behavior.

### Chunk 3: Safety rules
- Generate only new scaffold files for GPayment.
- Do not overwrite existing files.
- Do not modify project files.
- Do not modify Program.cs, Startup.cs, appsettings.json, or global configuration.
- Skip any file that already exists.
- After generation, report any remaining APayment, APay, or reference-domain names that still need manual business adaptation.

## File Instructions
### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment.UnitTests\Controllers\GPaymentControllerTests.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment.UnitTests\Controllers\APaymentControllerTests.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Rewrite test names, arrange data, mocks, expected responses, and assertions for the target feature behavior.
- Cover success, validation failure, dependency failure, mapping behavior, and error handling.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment.UnitTests\Managers\AccountEnrolmentManagerTest.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment.UnitTests\Managers\AccountEnrolmentManagerTest.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Rewrite test names, arrange data, mocks, expected responses, and assertions for the target feature behavior.
- Cover success, validation failure, dependency failure, mapping behavior, and error handling.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment.UnitTests\Mappers\ProcessPaymentRequestMapperTest.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment.UnitTests\Mappers\ProcessPaymentRequestMapperTest.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Rewrite test names, arrange data, mocks, expected responses, and assertions for the target feature behavior.
- Cover success, validation failure, dependency failure, mapping behavior, and error handling.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment.UnitTests\Mappers\ProcessPaymentResponseMapperTest.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment.UnitTests\Mappers\ProcessPaymentResponseMapperTest.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Rewrite test names, arrange data, mocks, expected responses, and assertions for the target feature behavior.
- Cover success, validation failure, dependency failure, mapping behavior, and error handling.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment.UnitTests\Processors\GPayProcessorTests.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment.UnitTests\Processors\APayProcessorTests.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Rewrite test names, arrange data, mocks, expected responses, and assertions for the target feature behavior.
- Cover success, validation failure, dependency failure, mapping behavior, and error handling.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment.UnitTests\Properties\AssemblyInfo.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment.UnitTests\Properties\AssemblyInfo.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Rewrite test names, arrange data, mocks, expected responses, and assertions for the target feature behavior.
- Cover success, validation failure, dependency failure, mapping behavior, and error handling.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\ApplicationStarter.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\ApplicationStarter.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Review DI registrations and startup hooks for the target feature; do not apply project/global registration changes without approval.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Controllers\GPaymentController.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Controllers\APaymentController.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Update route names, action names, request/response contracts, validation flow, logging, and HTTP status handling for GPayment.
- Keep actions asynchronous when dependencies perform I/O.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Dal\AccountEnrolmentDal.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Dal\AccountEnrolmentDal.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Update persistence model names, lookup keys, query assumptions, and repository contracts for the target domain.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Dal\IAccountEnrolmentDal.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Dal\IAccountEnrolmentDal.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Update persistence model names, lookup keys, query assumptions, and repository contracts for the target domain.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Dal\Models\AccountEnrolmentInfo.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Dal\Models\AccountEnrolmentInfo.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Update persistence model names, lookup keys, query assumptions, and repository contracts for the target domain.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\DependencyModule.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\DependencyModule.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Review DI registrations and startup hooks for the target feature; do not apply project/global registration changes without approval.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\ErrorHandling\GPayErrorCodes.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\ErrorHandling\APayErrorCodes.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Create target-specific error codes/messages and map validation/dependency failures to the existing error-handling style.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\ErrorHandling\ErrorHandler.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\ErrorHandling\ErrorHandler.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Create target-specific error codes/messages and map validation/dependency failures to the existing error-handling style.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Helpers\TransactionAmountValidator.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Helpers\TransactionAmountValidator.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Managers\AccountEnrolmentManager.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Managers\AccountEnrolmentManager.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Update domain coordination, validation rules, and exception handling to reflect the target feature requirements.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Managers\IAccountEnrolmentManager.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Managers\IAccountEnrolmentManager.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Update domain coordination, validation rules, and exception handling to reflect the target feature requirements.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Mappers\IProcessPaymentRequestMapper.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Mappers\IProcessPaymentRequestMapper.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Map target request fields to target operation/domain models; do not leave copied source-field mappings unless they still apply.
- Add null/validation-safe mapping behavior consistent with the reference mapper tests.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Mappers\IProcessPaymentResponseMapper.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Mappers\IProcessPaymentResponseMapper.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Map target request fields to target operation/domain models; do not leave copied source-field mappings unless they still apply.
- Add null/validation-safe mapping behavior consistent with the reference mapper tests.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Mappers\PaymentOpRequest.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Mappers\PaymentOpRequest.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Map target request fields to target operation/domain models; do not leave copied source-field mappings unless they still apply.
- Add null/validation-safe mapping behavior consistent with the reference mapper tests.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Mappers\ProcessPaymentRequestMapper.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Mappers\ProcessPaymentRequestMapper.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Map target request fields to target operation/domain models; do not leave copied source-field mappings unless they still apply.
- Add null/validation-safe mapping behavior consistent with the reference mapper tests.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Mappers\ProcessPaymentResponseMapper.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Mappers\ProcessPaymentResponseMapper.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Map target request fields to target operation/domain models; do not leave copied source-field mappings unless they still apply.
- Add null/validation-safe mapping behavior consistent with the reference mapper tests.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\MockData\MockDataHelper.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\MockData\MockDataHelper.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Models\Account.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Models\Account.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Replace copied fields with target request/response fields from the requirement; keep only shared fields that still make business sense.
- Update enums, state names, default values, and serialization contracts for the target domain.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Models\GPaySessionData.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Models\APaySessionData.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Replace copied fields with target request/response fields from the requirement; keep only shared fields that still make business sense.
- Update enums, state names, default values, and serialization contracts for the target domain.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Models\PaymentOpResponse.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Models\PaymentOpResponse.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Replace copied fields with target request/response fields from the requirement; keep only shared fields that still make business sense.
- Update enums, state names, default values, and serialization contracts for the target domain.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Models\PaymentRequestState.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Models\PaymentRequestState.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Replace copied fields with target request/response fields from the requirement; keep only shared fields that still make business sense.
- Update enums, state names, default values, and serialization contracts for the target domain.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Models\PaymentState.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Models\PaymentState.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Replace copied fields with target request/response fields from the requirement; keep only shared fields that still make business sense.
- Update enums, state names, default values, and serialization contracts for the target domain.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Models\ProcessPaymentResponse.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Models\ProcessPaymentResponse.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Replace copied fields with target request/response fields from the requirement; keep only shared fields that still make business sense.
- Update enums, state names, default values, and serialization contracts for the target domain.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Models\UpdatePaymentRequest.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Models\UpdatePaymentRequest.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Replace copied fields with target request/response fields from the requirement; keep only shared fields that still make business sense.
- Update enums, state names, default values, and serialization contracts for the target domain.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Models\VerifyPaymentRequest.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Models\VerifyPaymentRequest.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Replace copied fields with target request/response fields from the requirement; keep only shared fields that still make business sense.
- Update enums, state names, default values, and serialization contracts for the target domain.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Models\VerifyPaymentResponse.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Models\VerifyPaymentResponse.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Replace copied fields with target request/response fields from the requirement; keep only shared fields that still make business sense.
- Update enums, state names, default values, and serialization contracts for the target domain.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Processors\GPaymentProcessor.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Processors\APaymentProcessor.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Rewrite orchestration steps for the target business workflow, including dependency calls, failure handling, and response state transitions.
- Preserve dependency injection style and async boundaries from the reference processor.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Processors\GPaymentUpdateProcessor.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Processors\APaymentUpdateProcessor.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Rewrite orchestration steps for the target business workflow, including dependency calls, failure handling, and response state transitions.
- Preserve dependency injection style and async boundaries from the reference processor.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Processors\IGPaymentProcessor.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Processors\IAPaymentProcessor.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Rewrite orchestration steps for the target business workflow, including dependency calls, failure handling, and response state transitions.
- Preserve dependency injection style and async boundaries from the reference processor.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Processors\IGPaymentUpdateProcessor.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Processors\IAPaymentUpdateProcessor.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Rewrite orchestration steps for the target business workflow, including dependency calls, failure handling, and response state transitions.
- Preserve dependency injection style and async boundaries from the reference processor.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Properties\AssemblyInfo.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Properties\AssemblyInfo.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Services\GPayService.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Services\APayService.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Adapt external/internal service calls, update logic, status handling, and retry/error behavior to the target feature.
- Check for source-specific prefixes such as APay and rename them when they represent business semantics, not shared library names.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Services\IGPayService.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Services\IAPayService.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Adapt external/internal service calls, update logic, status handling, and retry/error behavior to the target feature.
- Check for source-specific prefixes such as APay and rename them when they represent business semantics, not shared library names.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Services\Updater\GPayRejectedUpdater.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Services\Updater\APayRejectedUpdater.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Adapt external/internal service calls, update logic, status handling, and retry/error behavior to the target feature.
- Check for source-specific prefixes such as APay and rename them when they represent business semantics, not shared library names.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Services\Updater\GPaySuccessUpdater.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Services\Updater\APaySuccessUpdater.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Adapt external/internal service calls, update logic, status handling, and retry/error behavior to the target feature.
- Check for source-specific prefixes such as APay and rename them when they represent business semantics, not shared library names.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Services\Updater\GPayUpdater.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Services\Updater\APayUpdater.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Adapt external/internal service calls, update logic, status handling, and retry/error behavior to the target feature.
- Check for source-specific prefixes such as APay and rename them when they represent business semantics, not shared library names.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Services\Updater\IGPayUpdater.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Services\Updater\IAPayUpdater.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Adapt external/internal service calls, update logic, status handling, and retry/error behavior to the target feature.
- Check for source-specific prefixes such as APay and rename them when they represent business semantics, not shared library names.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Services\Updater\Models\PaymentStatus.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Services\Updater\Models\PaymentStatus.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Adapt external/internal service calls, update logic, status handling, and retry/error behavior to the target feature.
- Check for source-specific prefixes such as APay and rename them when they represent business semantics, not shared library names.

### C:\Users\86198\Downloads\Solution Part1\Modules\GPayment\Services\Updater\Models\PaymentUpdaterRequest.cs
- Reference file: C:\Users\86198\Downloads\Solution Part1\Modules\APayment\Services\Updater\Models\PaymentUpdaterRequest.cs
- Planned action: Create
- Replace remaining reference-domain terms, constants, comments, routes, test data, and examples with target-domain equivalents.
- Keep the reference architecture and dependency boundaries, but update behavior to match the technical requirement chunks.
- Remove copied behavior that only applies to APayment and record any unresolved assumptions.
- Adapt external/internal service calls, update logic, status handling, and retry/error behavior to the target feature.
- Check for source-specific prefixes such as APay and rename them when they represent business semantics, not shared library names.

