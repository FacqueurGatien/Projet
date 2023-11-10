export class Restaurant{

    name:String;
    note:String;
    image:String;
    driveTime:String;

    constructor(_name, _note, _image, _driveTime){
        this.name=_name;
        this.note=_note;
        this.image=_image;
        this.driveTime=_driveTime;
    }

    getName(){
        return this.name;
    }
    getNote(){
        return this.note;
    }
    getImage(){
        return this.image;
    }
    getDriveTime(){
        return this.driveTime;
    }
}
