import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import { Book } from './book.model';
@Injectable({
  providedIn: 'root'
})
export class BookService {

  url:string="http://localhost:61658/api/books";
  books:Book[];
  book:Book;

  constructor(private http:HttpClient) { }
  
  getAllBooks(){
    this.http.get(this.url).toPromise().then(
      res=>{
        this.books = res as Book[];
      }
    )
  }
  postBook(){
    return this.http.post(this.url, this.book);
  }
  PutBook(){
    return this.http.put(this.url+"/"+this.book.id, this.book)
  }
  deleteBook(id){
    return this.http.delete(this.url+"/"+id);
  }
}
