import { FormGroup, FormArray, FormBuilder, Validators } from "@angular/forms";
import { Injectable } from "@angular/core";

export interface FormGroupFactory<TContract> {
    (fb: FormBuilder, data: TContract): FG
}

export interface ContractFactory<TContract> {
    (): TContract
}

export interface Comparer {
    (fg: FG, fg1: FG): boolean
}

export type FG = FormGroup & { 
    isEditable?: boolean  
    canEdit?: boolean
    canAdd?: boolean
    canDelete?: boolean
} 

@Injectable()
export class DataSource<TContract> {
    userTable: FormGroup;
    control: FormArray;
    touchedRows: any;
    private data: TContract[]

    fgFactory: FormGroupFactory<TContract>;
    contractFactory: ContractFactory<TContract>;

    constructor(private fb: FormBuilder) { }


    initialize(fgFact: FormGroupFactory<TContract>, contractFact: ContractFactory<TContract>, data: TContract[]) {
        this.fgFactory = fgFact;
        this.data = data;
        this.touchedRows = [];
        this.userTable = this.fb.group({
            tableRows: this.fb.array([])
        });
        this.control = this.userTable.get('tableRows') as FormArray;
    }

    initiateForm(data?: TContract): FG {
        if (!data) {
            return this.fgFactory(this.fb, this.contractFactory());
        }
        else {
            return this.fgFactory(this.fb, data);
        }
    }

    addRow() {
        const control = this.userTable.get('tableRows') as FormArray;
        control.push(this.initiateForm());
    }

    deleteRow(index: number) {
        const control = this.userTable.get('tableRows') as FormArray;
        control.removeAt(index);
    }

    editRow(group: FG) {
        group.isEditable = true;
    }

    saveUserDetails() {
        console.log(this.userTable.value);
    }

    get getFormControls() {
        const control = this.userTable.get('tableRows') as FormArray;
        return control;
    }

    submitForm() {
        const control = this.userTable.get('tableRows') as FormArray;
        this.touchedRows = control.controls.filter(row => row.touched).map(row => row.value);
        console.log(this.touchedRows);
    }
}