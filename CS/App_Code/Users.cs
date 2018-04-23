using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample {
    public class User {
        public string Id { get; private set; }
        List<string> documentIDs;
        private string userID;

        public User(string id) {
            this.Id = id;
        }

        public List<string> DocumentIDs {
            get {
                if (documentIDs == null)
                    documentIDs = new List<string>();
                return documentIDs;
            }
        }
    }

    public static class Users {
        static object syncRoot = new Object();

        private static volatile List<User> all;
        public static List<User> All {
            get {
                if (all == null) {
                    lock (syncRoot) {
                        if (all == null) {
                            all = new List<User>();
                        }
                    }
                }
                return all;
            }
        }

        public static string GetUserByDocument(string documentID) {
            lock (syncRoot) {
                foreach (var user in All) {
                    if (user.DocumentIDs.Contains(documentID))
                        return user.Id;
                }
                return null;
            }
        }

        public static User Register(string userID) {
            lock (syncRoot) {
                var user = new User(userID);
                All.Add(user);
                return user;
            }
        }
    }
}