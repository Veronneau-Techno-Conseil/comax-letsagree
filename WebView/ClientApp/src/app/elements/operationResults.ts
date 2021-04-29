

export class Response {
    messages?: string[]
    warnings?: string[]
    validations: ValidationErrors
    resultCode: number
    ok: boolean
}

export class ValidationErrors {
    [name:string]: string
}

export class Result<TContract> extends Response {
    data: TContract
}