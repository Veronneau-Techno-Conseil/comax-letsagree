
export interface DisplayMessage {
    (level: "warning"|"error"|"message", msg: string): void
}

export class Settings{
    static messageDisplayFn: DisplayMessage;
}