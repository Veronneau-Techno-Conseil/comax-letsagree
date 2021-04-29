
export class ActionType{
    id: number
    name: string
    component: string
}

export class Entity {
    id: number
    entityTypeId : number
    flowId: number    
    index: number
}

export class EntityAttribute{
    id: number
    name: string
    entityTypeId: number
    valueTypeId: number
    actionTypeId?: number
    translationCode: number
    index: number
}

export class EntityType {
    id: number
    name: string
}

export class Flow {
    id: number
    owner: number
    name: string
    description: string
}

export class Language{
    code: string
    name: string
}

export class Lookup{
    id: number
    code: string
    translationCode: string
}

export class Translation {
    code: string
    languageCode: string
    value: string 
}

export class User {
    id: number
    accountId: string
    name: string
    userType: string
}

export class UserType {
    code: string
    name: string
}

export class ValueType {
    id: number
    name: string
    component: string
    transCode: string
    lookupCode: string
}


