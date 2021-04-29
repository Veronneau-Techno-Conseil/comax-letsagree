import { HttpClient, HttpEvent, HttpResponse } from "@angular/common/http"
import { URL } from "url";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";

import { Result, Response } from "./operationResults";
import { Settings } from "./settings";

export interface SubUrl<TContract>{
    (contract: TContract): string
}

export abstract class ServiceBase<TContract> {
    
    constructor(private baseUrl: string, private client: HttpClient, private subUrl: SubUrl<TContract>){

    }

    private getUrl(contract: TContract) : string {
        const sub = this.subUrl(contract);
        const url = new URL(sub, this.baseUrl);
        return url.toString();
    }

    private handleErrors(res: Response){
        if(!Settings.messageDisplayFn)
            return;
        if(!!res.warnings){
            res.warnings.forEach(w => {
                Settings.messageDisplayFn("warning", w);
            });
        }
    }

    post(contract: TContract) : Observable<Result<TContract>>{
        const url = this.getUrl(contract);
        return this.client.post<Result<TContract>>(url, {
            body: contract
        })
        .pipe(map((v,i)=>{
            this.handleErrors(v);
            return v;
        }));
    }

    put(contract: TContract) : Observable<Response> {
        const url = this.getUrl(contract);
        return this.client.put<Response>(url, contract).pipe(map((v,i)=>{
            this.handleErrors(v);
            return v;
        }));
    }

    get(contract: TContract) : Observable<TContract> {
        const url = this.getUrl(contract);
        return this.client.get<TContract>(url);
    }

    delete(contract: TContract) : Observable<Response> {
        return this.client.delete<Response>(this.getUrl(contract)).pipe(map((v,i)=>{
            this.handleErrors(v);
            return v;
        }));
    }
}