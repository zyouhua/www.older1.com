using System;
using System.Reflection;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace platform
{
    public class MySqlSingleton : Headstream
    {
        public SqlStatus_ _runSql(ISqlSerialize nSqlSerialize)
        {
            string sqlCommand_ = nSqlSerialize._sqlCommand();
            SqlStatus_ sqlStatus_ = SqlStatus_.mSucess_;
            MySqlConnection mySqlConnection_ = new MySqlConnection(mConnectionString);
            try
            {
                mySqlConnection_.Open();
                MySqlCommand mySqlCommand_ = new MySqlCommand(sqlCommand_, mySqlConnection_);
                mySqlCommand_.ExecuteNonQuery();
            }
            catch (Exception exception_)
            {
                LogSingleton logSingleton_ = __singleton<LogSingleton>._instance();
                logSingleton_._logError(exception_.ToString());
                sqlStatus_ = SqlStatus_.mFail_;
            }
            mySqlConnection_.Close();
            return sqlStatus_;
        }

        public SqlStatus_ _runSql(ISqlSerialize nSqlSerialize, ISqlStream nSqlStream)
        {
            string sqlCommand_ = nSqlSerialize._sqlCommand();
            SqlStatus_ sqlStatus_ = SqlStatus_.mSucess_;
            MySqlSingleton mySqlSingleton_ = __singleton<MySqlSingleton>._instance();
            string connectionString_ = mySqlSingleton_._getConnectionString();
            MySqlConnection mySqlConnection_ = new MySqlConnection(connectionString_);
            try
            {
                mySqlConnection_.Open();
                MySqlCommand mySqlCommand_ = new MySqlCommand(sqlCommand_, mySqlConnection_);
                MySqlDataReader mySqlDataReader_ = mySqlCommand_.ExecuteReader();
                if (mySqlDataReader_.Read())
                {
                    MySqlDataReaderSerialize mySqlDataReaderSerialize_ = new MySqlDataReaderSerialize(mySqlDataReader_);
                    nSqlStream._serialize(mySqlDataReaderSerialize_);
                }
                mySqlDataReader_.Close();
            }
            catch (Exception exception_)
            {
                LogSingleton logSingleton_ = __singleton<LogSingleton>._instance();
                logSingleton_._logError(exception_.ToString());
                sqlStatus_ = SqlStatus_.mFail_;
            }
            mySqlConnection_.Close();
            return sqlStatus_;
        }

        public SqlStatus_ _runSql(ISqlSerialize nSqlSerialize, ISqlSerialize nSqlSerializeEx, ISqlStream nSqlStream)
        {
            string sqlCommand_ = nSqlSerialize._sqlCommand();
            sqlCommand_ += nSqlSerializeEx._sqlCommand();
            SqlStatus_ sqlStatus_ = SqlStatus_.mSucess_;
            MySqlSingleton mySqlSingleton_ = __singleton<MySqlSingleton>._instance();
            string connectionString_ = mySqlSingleton_._getConnectionString();
            MySqlConnection mySqlConnection_ = new MySqlConnection(connectionString_);
            try
            {
                mySqlConnection_.Open();
                MySqlCommand mySqlCommand_ = new MySqlCommand(sqlCommand_, mySqlConnection_);
                MySqlDataReader mySqlDataReader_ = mySqlCommand_.ExecuteReader();
                if (mySqlDataReader_.Read())
                {
                    MySqlDataReaderSerialize mySqlDataReaderSerialize_ = new MySqlDataReaderSerialize(mySqlDataReader_);
                    nSqlStream._serialize(mySqlDataReaderSerialize_);
                }
                mySqlDataReader_.Close();
            }
            catch (Exception exception_)
            {
                LogSingleton logSingleton_ = __singleton<LogSingleton>._instance();
                logSingleton_._logError(exception_.ToString());
                sqlStatus_ = SqlStatus_.mFail_;
            }
            mySqlConnection_.Close();
            return sqlStatus_;
        }

        public SqlStatus_ _runSql<__t>(ISqlSerialize nSqlSerialize, List<__t> nValues) where __t : ISqlStream
        {
            string sqlCommand_ = nSqlSerialize._sqlCommand();
            SqlStatus_ sqlStatus_ = SqlStatus_.mSucess_;
            MySqlSingleton mySqlSingleton_ = __singleton<MySqlSingleton>._instance();
            string connectionString_ = mySqlSingleton_._getConnectionString();
            MySqlConnection mySqlConnection_ = new MySqlConnection(connectionString_);
            try
            {
                mySqlConnection_.Open();
                MySqlCommand mySqlCommand_ = new MySqlCommand(sqlCommand_, mySqlConnection_);
                MySqlDataReader mySqlDataReader_ = mySqlCommand_.ExecuteReader();
                if (mySqlDataReader_.Read())
                {
                    MySqlDataReaderSerialize mySqlDataReaderSerialize_ = new MySqlDataReaderSerialize(mySqlDataReader_);
                    __t t_ = Activator.CreateInstance<__t>();
                    t_._serialize(mySqlDataReaderSerialize_);
                    nValues.Add(t_);
                }
                mySqlDataReader_.Close();
            }
            catch (Exception exception_)
            {
                LogSingleton logSingleton_ = __singleton<LogSingleton>._instance();
                logSingleton_._logError(exception_.ToString());
                sqlStatus_ = SqlStatus_.mFail_;
            }
            mySqlConnection_.Close();
            return sqlStatus_;
        }

        public SqlStatus_ _runSql<__t>(ISqlSerialize nSqlSerialize, ISqlSerialize nSqlSerializeEx, List<__t> nValues) where __t : ISqlStream
        {
            string sqlCommand_ = nSqlSerialize._sqlCommand();
            sqlCommand_ += nSqlSerializeEx._sqlCommand();
            SqlStatus_ sqlStatus_ = SqlStatus_.mSucess_;
            MySqlSingleton mySqlSingleton_ = __singleton<MySqlSingleton>._instance();
            string connectionString_ = mySqlSingleton_._getConnectionString();
            MySqlConnection mySqlConnection_ = new MySqlConnection(connectionString_);
            try
            {
                mySqlConnection_.Open();
                MySqlCommand mySqlCommand_ = new MySqlCommand(sqlCommand_, mySqlConnection_);
                MySqlDataReader mySqlDataReader_ = mySqlCommand_.ExecuteReader();
                if (mySqlDataReader_.Read())
                {
                    MySqlDataReaderSerialize mySqlDataReaderSerialize_ = new MySqlDataReaderSerialize(mySqlDataReader_);
                    __t t_ = Activator.CreateInstance<__t>();
                    t_._serialize(mySqlDataReaderSerialize_);
                    nValues.Add(t_);
                }
                mySqlDataReader_.Close();
            }
            catch (Exception exception_)
            {
                LogSingleton logSingleton_ = __singleton<LogSingleton>._instance();
                logSingleton_._logError(exception_.ToString());
                sqlStatus_ = SqlStatus_.mFail_;
            }
            mySqlConnection_.Close();
            return sqlStatus_;
        }

        public override void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mConnectionString, @"connectionString");
        }

        public override string _streamName()
        {
            return @"MySqlSingleton";
        }

        public string _getConnectionString()
        {
            return mConnectionString;
        }

        public MySqlSingleton()
        {
            mConnectionString = null;
        }

        string mConnectionString;
    }
}
